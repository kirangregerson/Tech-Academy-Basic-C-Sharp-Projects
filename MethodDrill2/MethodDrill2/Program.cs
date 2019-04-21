using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator Operate = new Operator();
            Console.WriteLine(Operate.Operation(12));
            Console.WriteLine(Operate.Operation(32.76));
            Console.WriteLine(Operate.Operation("6"));
            Console.ReadLine();
        }
    }
}
