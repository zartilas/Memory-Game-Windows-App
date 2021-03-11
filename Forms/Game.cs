using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia1
{
    public partial class Game : Form
    {
        Main main;
        bool game = false;
        bool allowClick = false;
        int counter = 0;
        int tries = 0;
        Random random = new Random();
        PictureBox firstTry, secondTry, firstClick, secondClick;
        Timer clickTimer = new Timer();

        public Game(Main mainForm)
        {
            InitializeComponent();
            main = new Main();
            this.main = mainForm;
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> DefaultImages
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.banana,
                    Properties.Resources.beer,
                    Properties.Resources.chef,
                    Properties.Resources.chefg,
                    Properties.Resources.chicken,
                    Properties.Resources.chocolate,
                    Properties.Resources.donut,
                    Properties.Resources.hotdog,
                    Properties.Resources.muffin,
                    Properties.Resources.pizza,
                    Properties.Resources.porridge,
                    Properties.Resources.shawarma
                };
            }
        }

        private PictureBox getSpace()
        {
            int i;
            do
            {
                i = random.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[i].Tag != null);
            return pictureBoxes[i];
        }

        private void clickTimer_tick(object sender, EventArgs e)
        {
            firstClick.Image = null;
            secondClick.Image = null;
            allowClick = true;
            clickTimer.Stop();
        }

        private void setImages()
        {
            string line1 = File.ReadLines("Settings.txt").First();
            if (line1 == "[Images]Custom")
            {
                string line2 = File.ReadLines("Settings.txt").ElementAtOrDefault(1);
                string dirImages = line2.Replace("[Directory]", "");
                string[] CustomImages = Directory.GetFiles(dirImages, "*.png");

                Image[] imagesArray = new Image[CustomImages.Length];

                for (int i = 0; i < imagesArray.Length; i++)
                {
                    imagesArray[i] = Image.FromFile(CustomImages[i]);
                }

                foreach (var img in imagesArray)
                {
                    getSpace().Tag = img;
                    getSpace().Tag = img;
                }
                return;
            }
            foreach (var img in DefaultImages)
            {
                getSpace().Tag = img;
                getSpace().Tag = img;
            }
        }

        private void ResetImages()
        {
            //Gia oles tis eikones tou kathe picturebox tis apothikevoume mia kathe fora kai tis 
            foreach (var img in pictureBoxes)
            {
                img.Tag = null;
                img.Visible = true;
            }
            HideImages();
            setImages();
            //Reset to timer sto 0
            counter = 0;
            tries = 0;
            labelTime.Text = "00:00";
            labelTries.Text = "Tries: 0";
            timer.Stop();
            timer.Start();
        }

        private void HideImages()
        {
            //Gia ola ta PictureBoxes aferoume tis eikones
            foreach (var img in pictureBoxes)
            {
                img.Image = null;
            }
        }

        private void pictureClick(object sender, EventArgs e)
        {
            //Otan to timer tha kanei run gia na deiksoume ston xristi pia eikona dialekse, tote
            //tha blockaroume to click sta alla koutia mexri na teliosei to timer
            if (!allowClick)
            {
                return;
            }
            //Efoson mporei o xristis pleon na kanei click kanoume save to prwto  prwti eikona pou dialekse
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox.Image != null)
            {
                return;
            }
            var img = (PictureBox)sender;

            if (firstTry == null)
            {
                firstTry = img;
                firstClick = clickedPictureBox;
                img.Image = (Image)img.Tag;
                return;
            }
            secondTry = img;
            secondClick = clickedPictureBox;
            img.Image = (Image)img.Tag;
            if (img.Image == firstTry.Image && img != firstTry)
            {
                img.Visible = firstTry.Visible;
                {
                    firstTry = img;
                }
            }
            else
            {
                tries += 1;
                labelTries.Text = "Tries: " + tries.ToString();
                allowClick = false;
                clickTimer.Start();
            }
            firstTry = null;
            secondTry = null;
            foreach (PictureBox pic in pictureBoxes)
            {
                if (pic.Image == null)
                {
                    return;
                }
            }
            timer.Stop();
            game = true;


            string path = "Data" + "\\" + main.comboBoxUsers.SelectedItem.ToString() + ".txt";
            //Se periptosi pou den yparxei to arxeio
            if (!File.Exists(path))
            {
                UserFile userFile = new UserFile(main.comboBoxUsers.SelectedItem.ToString(), tries, counter);
            }
            else
            {
                string line1 = File.ReadLines(path).First();
                int userTries = Int32.Parse(line1.Replace("[Tries]", ""));
                if (tries < userTries || userTries == -1)
                {
                    File.Delete(path);
                    FileStream fileStream = File.Create(path);
                    fileStream.Close();
                    UserFile userFile = new UserFile(main.comboBoxUsers.SelectedItem.ToString(), tries, counter);
                }
            }
            MessageBox.Show("YOU WIN!" + Environment.NewLine + "Tries ➜ " + tries + Environment.NewLine + "Time Spent ➜ " + string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            labelTime.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            string line1;
            labelUser.Text = "User: " + main.comboBoxUsers.SelectedItem.ToString();

            int bestScore = -1;
            string bestScoreUser = "";
            labelUserBest.Text = "Best Score: None";
            DirectoryInfo d = new DirectoryInfo("Data");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                line1 = File.ReadLines(file.FullName).First();
                int userTries = Int32.Parse(line1.Replace("[Tries]", ""));
                string user = file.Name.Replace(".txt", "");

                if (userTries != -1)
                {
                    if (user == main.comboBoxUsers.SelectedItem.ToString())
                    {
                        labelUserBest.Text = "Best Score: " + userTries;
                    }
                    if (userTries < bestScore || bestScore == -1)
                    {
                        bestScore = userTries;
                        bestScoreUser = user;
                    }
                }
            }
            if (bestScore == -1)
            {
                labelHighscore.Text = "Highscore: None";
                labelHighscoreUser.Text = "";
            }
            else
            {
                labelHighscore.Text = "Highscore: " + bestScore.ToString();
                labelHighscoreUser.Text = "User: " + bestScoreUser;
            }

            timer.Enabled = true;
            allowClick = true;
            clickTimer.Interval = 800;
            clickTimer.Tick += clickTimer_tick;

            SettingsFile settingsFile = new SettingsFile();
            setImages();
            HideImages();
        }


        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the game? Your progress will be lost!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (game != true)
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            ResetImages();
        }
    }
}
