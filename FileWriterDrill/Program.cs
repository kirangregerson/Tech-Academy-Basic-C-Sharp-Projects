using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriterDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\kiran\myProjects\Tech-Academy-Basic-C-Sharp-Projects\FileWriterDrill\log.txt", input);
            string text = File.ReadAllText(@"C:\Users\kiran\myProjects\Tech-Academy-Basic-C-Sharp-Projects\FileWriterDrill\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
