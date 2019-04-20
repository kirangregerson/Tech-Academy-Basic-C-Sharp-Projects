using System;
using System.Collections.Generic;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> intList = new List<int> { 230, 45, 98, 75, 14 };
                Console.WriteLine("Input a number to divide by");
                int divisor = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Results:");
                foreach (int dividend in intList)
                {
                    Console.WriteLine(dividend / divisor);
                }
                Console.ReadLine();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Cannot divide by a string");
            }
            Console.WriteLine("Program has passed the try/catch block. Press enter.");
            Console.ReadLine();
        }
    }
}

