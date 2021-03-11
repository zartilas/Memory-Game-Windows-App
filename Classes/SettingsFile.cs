using System.IO;

namespace FinalErgasia1
{
    class SettingsFile
    {
        public SettingsFile()
        {
            //Ean to arxeio den yparxei i einai adeio tote ektelese ton pio katw kwdika
            if (!File.Exists("Settings.txt") || new FileInfo("Settings.txt").Length == 0)
            {
                //Dimiourgoume to arxeio kai meta to klinoume gia na min mas vgazei exception
                FileStream fileStream = File.Create("Settings.txt");
                fileStream.Close();
                //Kanoume save mesa tin tin pio katw protasi kai allazoume grammi
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Settings.txt", true))
                {
                    file.Write("[Images]Default");
                    file.Close();
                }
            }
        }
    }
}
