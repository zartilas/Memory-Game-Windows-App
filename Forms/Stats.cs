using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia1.Forms
{
    public partial class Stats : Form
    {
        Main main;

        public Stats(Main mainForm)
        {
            InitializeComponent();
            main = new Main();
            this.main = mainForm;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            string path = "Data" + "\\" + main.comboBoxUsers.SelectedItem.ToString() + ".txt";
            //Se periptosi pou den yparxei to arxeio
            if (!File.Exists(path))
            {
                UserFile userFile = new UserFile(main.comboBoxUsers.SelectedItem.ToString(), -1, -1);
            }
            string line1 = File.ReadLines(path).First();
            string line2 = File.ReadLines(path).ElementAtOrDefault(1);
            int userTries = Int32.Parse(line1.Replace("[Tries]", ""));
            int userTime = Int32.Parse(line2.Replace("[Time]", ""));
            labelUser.Text = main.comboBoxUsers.SelectedItem.ToString();
            if (userTries == -1)
            {
                labelTries.Text = "You haven't played any" + Environment.NewLine + "games yet!";
                labelTime.Text = "";
                return;
            }
            labelTries.Text = "● Tries: " + userTries;
            labelTime.Text = "● Time: " + string.Format("{0:00}:{1:00}", (userTime / 60) % 60, userTime % 60);
        }
    }
}
