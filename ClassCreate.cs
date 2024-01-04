using System;
using System.IO;
using System.Security.AccessControl;

namespace VEEAM_Test_Task.CreateArchive
{
    public class ClassCreate
    {
        public static string pathNameAndArchive;
        public static string justName;
        public static string checkPathingFileCopy;
        public static string checkDirectory;

        public static void createOriginal()
        {
            //create original paste
            Console.WriteLine("Tell what path you want do create your archive please!");
            string pathing = Console.ReadLine();

            //function recive the pathing value to send to delete method on delete
            DeleteControl.archivePathing(pathing);


            Console.WriteLine("Insert the archive name!");
            string name = Console.ReadLine();

            //global variables who receive values and send to another functions
            pathNameAndArchive = $"{pathing}{name}";
            justName = $"{name} Copy";

            DirectoryInfo directoryInfo = new DirectoryInfo(pathing);
            checkDirectory = directoryInfo.FullName;
            checkDirectory = Path.Combine(checkDirectory, name);

            if (directoryInfo.Exists)
            {
                directoryInfo.CreateSubdirectory(name);
            }

            string helper = $"Your Original archive '{directoryInfo.FullName}' already created!";
            //Logs.feedbackInfos(helper);
        }

        public static void createCopy(string originalName = "")
        {
            //create the copy of original archive
            Console.WriteLine("Now, where do you want to create te reply of the archive?");
            string replyArchive = Console.ReadLine();
            DirectoryInfo copyDirectory = new DirectoryInfo(replyArchive);
            checkPathingFileCopy = copyDirectory.FullName;
            checkPathingFileCopy = Path.Combine(checkPathingFileCopy, justName);


            if (copyDirectory.Exists)
            {
                copyDirectory.CreateSubdirectory($"{justName}");
            }
            MainSelector.processChoices();
            Console.WriteLine($"your copy has been created!"); Console.ReadKey();
        }


    }
}

