using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SettingsFile settingsFile = new SettingsFile();

            String images;
            //Elexoume tin kathe grammi tou arxeiou
            foreach (string i in File.ReadLines("Settings.txt"))
            {
                //Ean i grammi periexei tin pio katw leksi tote einai i rithmisi gia tis epiloges twn eikonwn
                if (i.Contains("[Images]")) {
                    //Kanoume replace tin leksi gia na exoume mono tin kathari epilogi
                    images = i.Replace("[Images]", "");
                    if (images == "Default")
                    {
                        //Allazoume tin epilogi tou combobox sto Default Images
                        comboImages.SelectedIndex = 0;
                        return;
                    }
                    if (images == "Custom")
                    {
                        //Allazoume tin epilogi tou combobox sto Custom Images
                        comboImages.SelectedIndex = 1;
                        return;
                    }
                }

            }
        }

        //Otan to cursor mpenei stin perioxi tou picturebox
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            labelInfo.Visible = true;
        }

        //Otan to cursor vgenei apo tin perioxi tou picturebox
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            labelInfo.Visible = false;
        }

        private void comboImages_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Ean sto combobox einai epilegmeno to "Custom Images" option.
            if (comboImages.Text == "Custom Images")
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        //Allazoume to epilegmeno item tou combobox sto stoixeio 0 diladi sto "Default Images"
                        //epeidi den itan epitixis i allagei se Custom Images.
                        string line1 = File.ReadLines("Settings.txt").First();
                        if (line1 == "[Images]Default")
                        {
                            comboImages.SelectedIndex = 0;
                            return;
                        }
                        return;
                    }
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        //Apothikeuse ola ta arxeia apo ton fakelo me typo .png
                        string[] files = Directory.GetFiles(fbd.SelectedPath, "*.png");

                        //Ean den iparxoun 12 images ston fakelo, perisoteres i ligoteres
                        if (files.Length != 12)
                        {
                            MessageBox.Show("You must have 12 png images in your directory", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Allazoume to epilegmeno item tou combobox sto stoixeio 0 diladi sto "Default Images"
                            //epeidi den itan epitixis i allagei se Custom Images.
                            comboImages.SelectedIndex = 0;
                            return;
                        }
                        //Apothikeuoume tis grammes tou arxeiou
                        string text = File.ReadAllText("Settings.txt");
                        //Kanume replace tin sigkekrimeni grammi me tin alli epilogi
                        text = text.Replace("[Images]Default", "[Images]Custom");
                        //Ksana grafoume to arxeio me to neo periexomeno
                        File.WriteAllText("Settings.txt", text);

                        //Twra ksana grafoume se nea grammi mesa sto arxeio to directory pou dialekse o xristis gia tis eikones
                        using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter("Settings.txt", true))
                        {
                            file.Write(Environment.NewLine + "[Directory]" + fbd.SelectedPath);
                            file.Close();
                        }

                        //Allazoume to epilegmeno item tou combobox sto stoixeio 1 diladi sto "Custom Images"
                        comboImages.SelectedIndex = 1;
                        labelImagesFound.Visible = true;
                        labelImagesFound.Text = "Images successfully loaded! Found " + files.Length.ToString() + " images.";
                    }
                }
            }
            else if (comboImages.Text == "Default Images")
            {
                //Diagrafoume to arxeio kai to ksana dimiourgoume gia na apothikeusoume ta nea dedomena
                File.Delete("Settings.txt");
                FileStream fileStream = File.Create("Settings.txt");
                fileStream.Close();
                //Kanoume save mesa tin tin pio katw protasi
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Settings.txt", true))
                {
                    file.Write("[Images]Default");
                    file.Close();
                }
                //Krivoume to label to opoio mas enimeronei gia tis eikones pu vrethikan, den xriazete afou allaksame option
                labelImagesFound.Visible = false;
            }
        }
    }
}
