using System;
using System.IO;
using System.Timers;
using VEEAM_Test_Task.CreateArchive;

namespace VEEAM_Test_Task
{
    internal class SyncFiles
    {
        //imports to test the timer function
        #region
        public static Timer countSync;
        static string pathingOriginalFile = ClassCreate.pathNameAndArchive;
        static string pathingCopiedFile = ClassCreate.justName;
        #endregion
        public static void FileCopy(string originalPath = "", string destinyPath = "")
        {
            try
            {
                var archives = Directory.GetFiles(originalPath);
                var archDestiny = "";

                foreach (string arqOrigim in archives)
                {
                    archDestiny = Path.GetFileName(arqOrigim);
                    string combinedPathing = Path.Combine(destinyPath, archDestiny);
                    File.Copy(arqOrigim, combinedPathing, true);
                }
                Console.WriteLine("Files copied!");
                Logs.feedbackInfos("Files copied!");
                Timing();
                MainSelector.processChoices();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"failed to copy files, error: {ex.Message}");
            }
        }

        //first try to insert timer sincronization
        #region
        //public static void Timing()
        //{
        //    countSync = new System.Timers.Timer(5000);
        //    countSync.Elapsed += FileCopyFunction;
        //    countSync.AutoReset = true;
        //    countSync.Enabled = true;
        //    countSync.Start();
        //}

        ////public static void filePathingReceptor(string one = "", string two = "")
        ////{
        ////    pathingOriginalFile = one;
        ////    pathingCopiedFile = two;
        ////}

        //public static void FileCopyFunction(object sender, ElapsedEventArgs e)
        //{
        //    string originalPath = pathingOriginalFile;
        //    string destinyPath = Path.Combine(originalPath, pathingCopiedFile);

        //    //string mano = pathingOriginalFile;
        //    //string funciona = pathingCopiedFile;
        //    //string tentativa1 = Path.Combine(mano, funciona);
        //    FileCopy(originalPath, destinyPath);
        //    Console.WriteLine("função chamada");
        //    Console.ReadKey();
        //}
        #endregion
        //second try to insert timer sincronizatio
        #region
        public static void Timing()
        {
            countSync = new System.Timers.Timer(5000);
            countSync.Elapsed += FileCopyFunction;
            countSync.AutoReset = true;
            countSync.Enabled = true;
            countSync.Start();
        }

        public static void FileCopyFunction(object sender, ElapsedEventArgs e)
        {
            string originalPath = ClassCreate.pathNameAndArchive;
            string copiedPath = ClassCreate.justName;

            string combinedPathing = Path.Combine(originalPath, copiedPath);

            FileCopy(originalPath, combinedPathing);

            Console.WriteLine("Function called");
        }
        #endregion
    }
}
