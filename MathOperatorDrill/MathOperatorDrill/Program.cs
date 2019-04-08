using System;


namespace MathOperatorDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number to be multiplied by 50");
            double multiplicand = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(multiplicand) + " times 50 equals " + (multiplicand*50));

            Console.WriteLine("Please input a number to be added to 25");
            double addTo25 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(addTo25) + " plus 25 equals " + (addTo25 + 25));

            Console.WriteLine("Please input a number to be divided by 12.5");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(dividend) + " divided by 12.5 equals " + (dividend / 12.5));

            Console.WriteLine("Please input a number to see if it is greater than 50");
            double boolCheck = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(boolCheck > 50));

            Console.WriteLine("Please input an integer to find its remainder when divided by 7");
            long modulus = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(Convert.ToString(modulus) + " divided by 7 leaves " + (modulus % 7) + " as a remainder");


            Console.Read();
        }
    }
}
