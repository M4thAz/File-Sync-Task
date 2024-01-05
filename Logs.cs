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
            Console.WriteLine("Insert the file name!");
            string nameTxtFile = $"{Console.ReadLine()}.txt";

            combined = Path.Combine(pathingTxtFile, nameTxtFile);

            using (StreamWriter nameFile = new StreamWriter(combined, true)) { }
        }

        public static string feedbackInfos(string text = "")
        {
            using (StreamWriter infosReceived = File.AppendText(combined))
            {
                infosReceived.WriteLine($"[{DateTime.Now.ToString("dddd, dd MMMM yyyy - hh:mmtt")}] - {text}");
            }
            return null;
        }
    }
}
