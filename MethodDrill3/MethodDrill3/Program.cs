using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator Operator = new Operator();
            Console.WriteLine("Input an integer value");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input an integer value to multiply by (you may leave this field empty, which defaults to 2)");

            try
            {
                int y = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(Operator.Multiply(x, y));
            }
            catch
            {
                Console.WriteLine(Operator.Multiply(x));
            }
            Console.ReadLine();
        }
    }
}
