using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowTime = DateTime.Now;
            Console.WriteLine(nowTime);
            Console.WriteLine("Input an integer");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime thenTime = nowTime.AddHours(hours);
            Console.WriteLine(thenTime);
            Console.ReadLine();
        }
    }
}
