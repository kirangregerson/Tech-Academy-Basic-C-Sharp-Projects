using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

            Console.WriteLine("Input an Integer to add to 3");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = operation.AddThree(input);
            Console.WriteLine("Output is " + output);

            Console.WriteLine("Input an Integer to subtract 3 from");
            input = Convert.ToInt32(Console.ReadLine());
            output = operation.SubtractThree(input);
            Console.WriteLine("Output is " + output);

            Console.WriteLine("Input an Integer to add to 3");
            input = Convert.ToInt32(Console.ReadLine());
            output = operation.MultiplyThree(input);
            Console.WriteLine("Output is " + output);

            Console.ReadLine();
        }
    }
}
