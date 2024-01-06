using System;
using System.IO;

namespace VEEAM_Test_Task
{
    internal class Logs
    {
        public static string combined;
        public static void TextFileCreator()
        {
            Console.WriteLine("Lets create your TXT file, please chose a pathing");
            string pathingTxtFile = Console.ReadLine();
            if (IsValidPathing(pathingTxtFile))
            {
                Console.WriteLine("Insert the file name!");
                string nameTxtFile = $"{Console.ReadLine()}.txt";
                combined = Path.Combine(pathingTxtFile, nameTxtFile);
                using (StreamWriter nameFile = new StreamWriter(combined, true)) { }
                MainSelector.processChoices();
            }
            else
            {
                Console.WriteLine("Please insert a valid pathing!");
                TextFileCreator();
            }
        }


        //verification pathing and info 
        #region
        public static bool IsValidPathing(string verifyValidPathing)
        {
            try
            {
                return Directory.Exists(verifyValidPathing);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string feedbackInfos(string text = "")
        {
            using (StreamWriter infosReceived = File.AppendText(combined))
            {
                infosReceived.WriteLine($"[{DateTime.Now.ToString("dddd, dd MMMM yyyy - hh:mmtt")}] - {text}");
            }
            return null;
        }
        #endregion
    }
}
