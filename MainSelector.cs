using System;
using VEEAM_Test_Task.CreateArchive;

namespace VEEAM_Test_Task
{
    internal class MainSelector
    {

        static void Main(string[] args)
        {
            processChoices();
        }



        public static void processChoices()
        {

            string name = ClassCreate.nameArchive;
            Console.WriteLine("What did you want to do now?");
            Console.WriteLine("1-Create Original and copy at the same time");
            Console.WriteLine("2-Create Original");
            Console.WriteLine("3-Create Copy");
            Console.WriteLine("4-Delete Options!");
            Console.WriteLine("5-Exit");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1":
                    ClassCreate.createOriginal();
                    ClassCreate.createCopy();
                    break;

                case "2":
                    ClassCreate.createOriginal();
                    break;

                case "3":
                    ClassCreate.createCopy();
                    break;

                case "4":
                    DeleteControl.deleteArchive(name);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
