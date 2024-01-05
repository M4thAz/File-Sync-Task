using System;
using System.IO;

namespace VEEAM_Test_Task
{
    internal class DeleteControl
    {

        public static void deleteArchive(string originalFilePathing, string copyFilePathing = "")
        {
            Console.WriteLine("Delete archive?");
            Console.WriteLine("1-Delete file and content!");
            Console.WriteLine("2-Delete file content!");
            Console.WriteLine("3-Back to main menu");
            string deleteOptions = Console.ReadLine();

            string archivePath = archivePathing(originalFilePathing);
            string fileCopyArchivePath = archivePathing(copyFilePathing);

            var archives = Directory.GetFiles(archivePath);
            var copyArchives = Directory.GetFiles(fileCopyArchivePath);


            switch (deleteOptions)
            {
                case "1":
                    if (Directory.Exists(archivePath) && Directory.Exists(fileCopyArchivePath))
                    {
                        Directory.Delete(archivePath, true);
                        Directory.Delete(fileCopyArchivePath, true);
                        Logs.feedbackInfos("Files deleted!");
                        MainSelector.processChoices();
                    }
                    break;

                case "2":
                    try
                    {
                        foreach (string loopFile in archives)
                        {
                            string deleteContent = Path.GetFileName(loopFile);
                            File.Delete(loopFile);

                            foreach (string loopCopyFile in copyArchives)
                            {
                                string pathingCopyDelete = Path.GetFileName(loopCopyFile);
                                File.Delete(loopCopyFile);
                            }
                        }
                        Logs.feedbackInfos("Deleted all content!");
                        MainSelector.processChoices();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"error try again");
                    }
                    break;

                case "3":
                    MainSelector.processChoices();
                    break;

                default:
                    MainSelector.processChoices();
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
