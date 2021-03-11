using FinalErgasia1.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace FinalErgasia1
{
    public partial class Main : Form
    {
        bool show;

        public Main()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Ean den yparxei epilogi sto combobox.
            if (comboBoxUsers.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a User!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Efoson epilegi xristis tote klise tin forma main kai anikse tin forma gia to paixnidi.
            Game formGame = new Game(this);
            this.Hide();
            formGame.ShowDialog();
            this.Close();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if (show == false)
            {
                labelEnterUser.Visible = true;
                textBoxEnterUser.Visible = true;
                buttonCreateUserConf.Visible = true;
                labelUserRules.Visible = true;
                show = true;
            }
            else
            {
                labelEnterUser.Visible = false;
                textBoxEnterUser.Visible = false;
                buttonCreateUserConf.Visible = false;
                labelUserRules.Visible = false;
                show = false;
            }
        }

        private void buttonCreateUserConf_Click(object sender, EventArgs e)
        {
            //Ean to textbox einai adio tote tha emfanisti to pio katw minima kai kanei to
            //function na kanei return kai den tha ektelesti o kwdikas pou einai katw apo to if.
            if (textBoxEnterUser.Text == "")
            {
                MessageBox.Show("You must enter a Username to create a user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Elexos ean yparxei to username idi
            DirectoryInfo d = new DirectoryInfo("Data");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                if (file.Name == textBoxEnterUser.Text.ToString() + ".txt")
                {
                    MessageBox.Show("Username already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            UserFile userFile = new UserFile(textBoxEnterUser.Text, -1, -1);

            //Prostheti ton user pu einai sto textbox sto combobox kai tou kanei unselect opiondipote xristi exei dialeksei.
            comboBoxUsers.Enabled = true;
            comboBoxUsers.Items.Add(textBoxEnterUser.Text);
            comboBoxUsers.SelectedItem = textBoxEnterUser.Text;

            //Afou dimiourgithei o xristis, kanei hide ta pio katw pedia.
            labelEnterUser.Visible = false;
            textBoxEnterUser.Visible = false;
            buttonCreateUserConf.Visible = false;
            labelUserRules.Visible = false;
            show = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Ean o fakelos Data den iparxei tote dimiourgise ton.
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            //Otan o fakelos exei periexomena pare ola ta arxeia pou typou .txt kai apothikefse ta mesa se ena array.
            if (new DirectoryInfo("Data").GetFileSystemInfos().Length != 0)
            {
                DirectoryInfo d = new DirectoryInfo("Data");
                FileInfo[] Files = d.GetFiles("*.txt");
                //Gia kathe arxeio .txt pou yparxei mesa sto Data pare ola ta onomata twn arxeiwn, 
                //kane replace to .txt me tipota kai kane add ton user sto combobox.
                foreach (FileInfo file in Files)
                {
                    String user = file.Name.ToString().Replace(".txt", "");
                    comboBoxUsers.Items.Add(user);
                }
                return;
            }
            //Ean den yparxoun users tote kane disable to combobox
            comboBoxUsers.Enabled = false;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Otan allaksi i epilogi sto combobox tote kane to label sto pio katw text epidi 
            //exei epilexthei xristis kai kane orato to koumpi gia to profile.
            labelSelectUser.Text = "Selected User:";
            buttonStats.Visible = true;
        }

        private void textBoxEnterUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Auto tha apotrepsei ton xristi na xrisimopisi space & allous xaraktires.
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar))) {
                e.Handled = true;
            }
        }
        private void textBoxEnterUser_KeyDown(object sender, KeyEventArgs e)
        {
            //Apenergopioisi tou paste (Ctrl + V).
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void buttonLeaderboards_Click(object sender, EventArgs e)
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.ShowDialog();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(this);
            stats.ShowDialog();
        }
    }
}
