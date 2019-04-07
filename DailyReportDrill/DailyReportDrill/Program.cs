using System;

namespace DailyReportDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? (True or False)");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Any positive experiences you'd like to share?");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("Any other feedback you'd like to share?");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            double studyHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
