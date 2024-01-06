using System;
using VEEAM_Test_Task.CreateArchive;

namespace VEEAM_Test_Task
{
    internal class MainSelector
    {

        static void Main(string[] args)
        {
            Logs.TextFileCreator();
            SyncFiles.Timing();
        }

        //main function who gives options to the user to do what he want
        #region
        public static void processChoices()
        {
            string name = ClassCreate.pathNameAndArchive;
            string nameCopy = ClassCreate.justName;
            string pathingFile = ClassCreate.checkPathingFileCopy;

            Console.WriteLine("Select action!");
            Console.WriteLine("1-Create Files");
            Console.WriteLine("2-Delete Options!");
            Console.WriteLine("3-Copy folder");
            Console.WriteLine("4-Close Program");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1":
                    ClassCreate.createOriginal();
                    ClassCreate.createCopy(nameCopy);
                    break;

                case "2":
                    DeleteControl.deleteArchive(name, pathingFile);
                    break;
                case "3":
                    SyncFiles.FileCopy(name, pathingFile);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

            }
        }
        #endregion
    }
}
