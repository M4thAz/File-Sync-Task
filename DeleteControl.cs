using System;
using System.IO;

namespace VEEAM_Test_Task
{
    internal class DeleteControl
    {

        public static void deleteArchive(string test)
        {
            Console.WriteLine("Delete archive?");
            Console.WriteLine("1-Yes");
            Console.WriteLine("2-Back to main menu");
            string deleteOptions = Console.ReadLine();

            string archivePath = archivePathing(test);



            switch (deleteOptions)
            {
                case "1":
                    if (Directory.Exists(archivePath))
                    {
                        Directory.Delete(archivePath, true);
                    }
                    MainSelector.processChoices();
                    break;

                case "2":
                    MainSelector.processChoices();
                    break;

                default:

                    break;
            }
        }


        public static string archivePathing(string createClassPathingName)
        {
            string received = createClassPathingName;
            return received;
        }
    }
}
