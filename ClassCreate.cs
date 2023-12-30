using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEEAM_Test_Task.CreateArchive
{
    public class ClassCreate
    {

        public static void createOriginal()
        {
            //create original paste
            Console.WriteLine("Tell what path you want do create your archive please!");
            string pathing = Console.ReadLine();

            Console.WriteLine("Insert the name of the archive!");
            string nameArchive = Console.ReadLine();


            DirectoryInfo directoryInfo = new DirectoryInfo(pathing);
            if (directoryInfo.Exists)
            {
                directoryInfo.CreateSubdirectory(nameArchive);
            }

            Console.WriteLine($"Your Original archive '{directoryInfo.FullName}' already created!");
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

