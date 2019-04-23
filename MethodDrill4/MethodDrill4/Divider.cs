using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    public class Divider
    {
        public void Halve(int x)
        {
            Console.WriteLine(x/2);
        }
        public static void Multiply(out int x, out int y)
        {
            Console.WriteLine("Enter the first of two values to multiply");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the second of two values to multiply");
            y = Convert.ToInt16(Console.ReadLine()); 
        }
        public static void Multiply(out int z)
        {
            Console.WriteLine("Enter a value to multiply (by 2)");
            z = Convert.ToInt16(Console.ReadLine());
        }
    }
}
