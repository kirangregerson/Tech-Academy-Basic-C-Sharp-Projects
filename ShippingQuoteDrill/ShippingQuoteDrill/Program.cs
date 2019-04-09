using System;

namespace ShippingQuoteDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express");
            Console.WriteLine("Please Follow the Instructions Below");
            Console.WriteLine("What is the Weight of the Package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if(packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            Console.WriteLine("What is the Width of the Package?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Height of the Package?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Length of the Package?");
            int packageLength= Convert.ToInt32(Console.ReadLine());
            if(packageHeight+packageLength+packageWidth > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            double totalCost = ((double)(packageHeight + packageLength + packageWidth) * (double)packageWeight) / 100;
            Console.WriteLine("Your Estimated Cost is " + totalCost + " Dollars.");
            Console.WriteLine("Thank You!");
            Console.Read();
            Console.Read();
        }
    }
}
