using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the link here: ");
            string fileDir = Console.ReadLine();
            if (Directory.Exists(fileDir))
            {
                string[] myDic = Directory.GetDirectories(fileDir);
                string[] myFiles = Directory.GetFiles(fileDir);
                foreach (string item in myDic)
                {
                    DirectoryInfo a = new DirectoryInfo(item);
                    Console.WriteLine(a.Name);
                }
                foreach (string item in myFiles)
                {
                    FileInfo file = new FileInfo(item);
                    Console.WriteLine(file.Name);
                }
            }
            else
            {
                Console.WriteLine("Route does not exist. Try again!");
            }
            Console.ReadLine();
        }
    }
}
