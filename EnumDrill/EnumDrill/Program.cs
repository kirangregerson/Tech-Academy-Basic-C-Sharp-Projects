using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week (capitalized)");
                Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That is not a valid day of the week (or is not capitalized)");
            }
            Console.ReadLine();
        }
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday          
        }
    }
}
