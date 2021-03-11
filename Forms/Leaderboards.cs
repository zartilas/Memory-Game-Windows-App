using FinalErgasia1.Classes;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalErgasia1
{
    public partial class Leaderboards : Form
    {
        public Leaderboards()
        {
            InitializeComponent();
        }


        private void Leaderboards_Load(object sender, EventArgs e)
        {
            //Ean o fakelos Data den periexei arxeia tote den yparxoun users
            if (new DirectoryInfo("Data").GetFileSystemInfos().Length == 0)
            {
                return;
            }

            DirectoryInfo d = new DirectoryInfo("Data");
            FileInfo[] Files = d.GetFiles("*.txt");
            int userFiles = 0;
            foreach (FileInfo file in Files)
            {
                string line1 = File.ReadLines(file.FullName).First();
                string userTries = line1.Replace("[Tries]", "");
                if (userTries != "-1")
                {
                    userFiles++;
                }
            }

            //int numFiles = Directory.GetFiles("Data", "*.txt", SearchOption.TopDirectoryOnly).Length;
            string[,] data = new string[userFiles, 3];
            int i = 0, j = 0;
            foreach (FileInfo file in Files)
            {
                string line1 = File.ReadLines(file.FullName).First();
                string line2 = File.ReadLines(file.FullName).ElementAtOrDefault(1);

                string userTries = line1.Replace("[Tries]", "");
                if (userTries != "-1")
                {
                    data[i, j] = file.Name.Replace(".txt", "");
                    data[i, j + 1] = userTries;
                    data[i, j + 2] = line2.Replace("[Time]", "");
                    i++;
                    j = 0;
                }
            }

            ArraySort comparer = new ArraySort(data, 1);
            string[,] sortedData = comparer.ToSortedArray();

            int pos = 1, index;

            if (userFiles <= 10)
            {
                index = userFiles;
            }
            else
            {
                index = 10;
            }
            labelScores.Text = "";
            for (i = 0; i < index; i++)
            {
                int time = Int32.Parse(sortedData[i, 2]);
                labelScores.Text += pos + "st. "
                    + sortedData[i, 0] + " | Tries: "
                    + sortedData[i, 1] + " | Time: "
                    + string.Format("{0:00}:{1:00}", (time / 60) % 60, time % 60) + " " 
                    + Environment.NewLine;
                pos++;
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
