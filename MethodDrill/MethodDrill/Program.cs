using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation Operator = new Operation();
            Operator.Operate(3, 28);
            Operator.Operate(x : 3, y : 28);
            Console.ReadLine();
        }
    }
}
