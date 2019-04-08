using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Please Input Hourly Rate of Person 1");
            double p1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Input Hours Worked Per Week of Person 1");
            double p1HoursPerWeek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2:");
            Console.WriteLine("Please Input Hourly Rate of Person 2");
            double p2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Input Hours Worked Per Week of Person 2");
            double p2HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            double p1YearSalary = p1HourlyRate * p1HoursPerWeek * 52;
            double p2YearSalary = p2HourlyRate * p2HoursPerWeek * 52;

            Console.WriteLine("Yearly Rate of Person 1: " + (p1YearSalary));
            Console.WriteLine("Yearly Rate of Person 2: " + (p2YearSalary));
            Console.WriteLine("Does Person 1 Earn more? ");
            Console.WriteLine(p1YearSalary > p2YearSalary);
            Console.Read();


        }
    }
}
