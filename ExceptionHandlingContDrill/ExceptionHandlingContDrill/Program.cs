using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingContDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your age");
            uint age;
            try
            {
                age = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine(DateTime.Now.Year - age);
                Console.ReadLine();
            }
            catch(OverflowException)
            {
                Console.WriteLine("input cannot be negative");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                Console.ReadLine();
            }
           
        }
    }
}
