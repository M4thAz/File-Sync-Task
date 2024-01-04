using System;
using System.IO;
using VEEAM_Test_Task.CreateArchive;

namespace VEEAM_Test_Task
{
    internal class Logs
    {
        string pathingReceptor = DeleteControl.archivePathing("adsa");
        string directoryReceptor = ClassCreate.checkDirectory;
        public static string combined = "";
        DirectoryInfo directory = new DirectoryInfo(directoryReceptor);

        public static void TextFileCreator()
        {
            Console.WriteLine("Insert the pathing of your file!");
            string pathingTxtFile = Console.ReadLine();
            Console.WriteLine("Insert the name");
            string nameTxtFile = $"{Console.ReadLine()}.txt";

            combined = Path.Combine(pathingTxtFile, nameTxtFile);

            using (StreamWriter nameFile = new StreamWriter(combined, true))
            {

            }
            feedbackInfos();
        }

        public static string feedbackInfos(string text = "")
        {
            string sendTextInfo = combined;
            if (Directory.Exists(directoryReceptor))
            {
                using (StreamWriter infosReceived = new StreamWriter(combined))
                {
                    infosReceived.WriteLine($"AH MANO ESCREVE ALGO POR FAVOR");
                }
            }
                Console.ReadKey();
            
            return null;
        }
    }
}
