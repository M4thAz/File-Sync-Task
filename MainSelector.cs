using System;
using VEEAM_Test_Task.CreateArchive;

namespace VEEAM_Test_Task
{
    internal class MainSelector
    {

        static void Main(string[] args)
        {
            Logs.TextFileCreator();
            processChoices();
        }



        public static void processChoices()
        {
            string name = ClassCreate.pathNameAndArchive;
            string nameCopy = ClassCreate.justName;
            string pathingFile = ClassCreate.checkPathingFileCopy;

            Console.WriteLine("Select action!");
            Console.WriteLine("1-Create Original and copy at the same time");
            Console.WriteLine("2-Create Original");
            Console.WriteLine("3-Delete Options!");
            Console.WriteLine("4-Copy folder");
            Console.WriteLine("6-random");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1":
                    ClassCreate.createOriginal();
                    ClassCreate.createCopy(nameCopy);
                    break;

                case "2":
                    ClassCreate.createOriginal();
                    break;

                case "3":
                    DeleteControl.deleteArchive(name, pathingFile);
                    break;

                case "4":
                    SyncFiles.FileCopy(name, pathingFile);
                    break;
                case "5":
                    Logs.TextFileCreator();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
