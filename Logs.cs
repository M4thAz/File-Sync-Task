using System;
using System.IO;

namespace VEEAM_Test_Task
{
    internal class Logs
    {

        public static void TextFileCreator()
        {
            Console.WriteLine("Insert the pathing of your file!");
            string pathingTxtFile = Console.ReadLine();
            Console.WriteLine("Insert the name");
            string nameTxtFile = $"{Console.ReadLine()}.txt";

            string combinedPathing = Path.Combine(pathingTxtFile, nameTxtFile);

            TextWriter nameFile = new StreamWriter(combinedPathing, false);
            feedbackInfos(nameFile);
            Console.WriteLine(feedbackInfos(nameFile));
            Console.ReadKey();
        }

        public static string feedbackInfos(string pathing = "", string text = "")
        {
            string sendTextInfo = text;
            string sendPathingInfo = pathing;
            StreamReader infoReceiver = new StreamReader(sendPathingInfo);



        }
    }
}
