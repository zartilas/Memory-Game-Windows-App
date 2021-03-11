using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalErgasia1
{
    class UserFile
    {
        
        public UserFile(string user, int tries, int time)
        {
            //Dimiourga to arxeio me to username tu xristi
            string userPath = "Data" + "\\" + user + ".txt";
            FileStream fileStream = File.Create(userPath);
            fileStream.Close();
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(userPath, true))
            {
                file.Write("[Tries]" + tries + Environment.NewLine + "[Time]" + time);
                file.Close();
            }
        }
    }
}
