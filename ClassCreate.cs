using System;
using System.IO;

namespace VEEAM_Test_Task.CreateArchive
{
    public class ClassCreate
    {
        public static string nameArchive;

        public static void createOriginal()
        {
            //create original paste
            Console.WriteLine("Tell what path you want do create your archive please!");
            string pathing = Console.ReadLine();

            //function recive the pathing value to send to delete method on delete
            DeleteControl.archivePathing(pathing);


            Console.WriteLine("Insert the name of the archive!");
            string name = Console.ReadLine();

            nameArchive = $"{pathing}{name}";

            DirectoryInfo directoryInfo = new DirectoryInfo(pathing);

            if (directoryInfo.Exists)
            {
                directoryInfo.CreateSubdirectory(name);
            }

            Console.WriteLine($"Your Original archive '{directoryInfo.FullName}' already created!");
            Console.WriteLine(pathing);
            MainSelector.processChoices();
        }

        public static void createCopy()
        {
            //create the copy of original archive
            Console.WriteLine("Now, where do you want to create te reply of the archive?");
            string replyArchive = Console.ReadLine();
            DirectoryInfo copyDirectory = new DirectoryInfo(replyArchive);


            if (copyDirectory.Exists)
            {
                copyDirectory.CreateSubdirectory("VEAMCOPY");
            }
            Console.WriteLine($"your copy has been created!"); Console.ReadKey();
        }
    }
}

