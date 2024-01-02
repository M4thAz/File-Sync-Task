using System;
using System.IO;

namespace VEEAM_Test_Task
{
    internal class SyncFiles
    {
        public static void FileCopy(string originalPath = "", string destinyPath = "")
        {
            try
            {
                var archives = Directory.GetFiles(originalPath);
                var archDestiny = "";

                foreach (string arqOrigim in archives)
                {
                    archDestiny = Path.GetFileName(arqOrigim);
                    string teste = Path.Combine(destinyPath, archDestiny);
                    File.Copy(arqOrigim, teste);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"failed to copy files, error: {ex.Message}");

            }
        }
    }
}
