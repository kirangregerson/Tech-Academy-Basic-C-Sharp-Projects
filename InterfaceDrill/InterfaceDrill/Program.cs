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
            Employee<string> employee1 = new Employee<string>();
            employee1.things = new List<string>();
            employee1.things.Add("badge");
            employee1.things.Add("phone");
            employee1.things.Add("wallet");
            employee1.things.Add("keys");

            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>();
            employee2.things.Add(2);
            employee2.things.Add(10);
            employee2.things.Add(39);
            employee2.things.Add(155);

            foreach(string item in employee1.things)
            {
                Console.WriteLine(item);
            }
            foreach (int number in employee2.things)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();


            //IQuittable employee = new Employee();
            //employee.Quit();

            //Employee emp1 = new Employee();
            //emp1.firstName = "Jeremy";
            //emp1.lastName = "Irons";

            //Employee emp2 = new Employee();
            //emp2.firstName = "Jeremy";
            //emp2.lastName = "Irons";

            //Console.WriteLine(emp1 == emp2);
            //Console.ReadLine();
        }
    }
}
