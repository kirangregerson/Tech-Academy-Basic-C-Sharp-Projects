using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.amount = 80.794m;
            Console.WriteLine(num1.amount);
            Console.ReadLine();
        }
    }
}
