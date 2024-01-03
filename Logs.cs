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
            string nameTxtFile = Console.ReadLine();

            string helper = $"{nameTxtFile}.txt";

            string combinedPathing = Path.Combine(pathingTxtFile, helper);

            TextWriter nameFile = new StreamWriter(combinedPathing, false);
            Console.WriteLine(nameFile);
            Console.ReadKey();
        }


    }
}
