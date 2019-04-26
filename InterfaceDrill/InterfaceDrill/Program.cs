using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();
            employee.Quit();

            Employee emp1 = new Employee();
            emp1.firstName = "Jeremy";
            emp1.lastName = "Irons";

            Employee emp2 = new Employee();
            emp2.firstName = "Jeremy";
            emp2.lastName = "Irons";

            Console.WriteLine(emp1 == emp2);
            Console.ReadLine();
        }
    }
}
