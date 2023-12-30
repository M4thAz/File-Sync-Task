using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VEEAM_Test_Task.CreateArchive;

namespace VEEAM_Test_Task
{
    internal class MainSelector
    {
        static void Main(string[] args)
        {
            processChoices();
        }
      
        //static void deleteArchive()
        //{
        //    Console.WriteLine("What archive do you want to delete ?");
        //    Console.WriteLine("1-Both");
        //    Console.WriteLine("2-Just the original");
        //    Console.WriteLine("3-Just the copy");
        //    Console.WriteLine("4-Back to main menu");
            
        //    string deleteArchives = Console.ReadLine();
        //    DirectoryInfo deleteDirectory = new DirectoryInfo(deleteArchives);

        //    switch (deleteArchives)
        //    {
        //        case "1": deleteDirectory();
        //            break;
        //    }
        //}


        static void processChoices()
        {
            Console.WriteLine("What did you want to do now?");
            Console.WriteLine("1-Create Original and copy at the same time");
            Console.WriteLine("2-Create Original");
            Console.WriteLine("3-Create Copy");
            Console.WriteLine("4-Exit");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1": ClassCreate.createOriginal();
                           ClassCreate.createCopy();
                break;

                case "2": ClassCreate.createOriginal(); 
                break;

                case "3": ClassCreate.createCopy();
                break;

                case "4": Environment.Exit(0);
                break;

            }
        }
    }
}
