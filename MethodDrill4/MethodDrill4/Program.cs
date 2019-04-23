using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider divider = new Divider();
            Console.WriteLine("Input an integer to divide by two");
            int input = Convert.ToInt16(Console.ReadLine());
            divider.Halve(input);
            int x, y, z;
            Divider.Multiply(out x, out y);
            Console.WriteLine(x * y);
            Divider.Multiply(out z);
            Console.WriteLine(z*2);
        }
    }
}
