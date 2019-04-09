using System;

namespace CarInsuranceDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("What Is Your Age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have You Ever Had a DUI? (True or False)");
            bool haveDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How Many Speeding Tickets do you Have?");
            int numTickets = Convert.ToInt16(Console.ReadLine());
            bool isQualified = age > 15 && haveDUI == false && numTickets < 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.Read();
        }
    }
}
