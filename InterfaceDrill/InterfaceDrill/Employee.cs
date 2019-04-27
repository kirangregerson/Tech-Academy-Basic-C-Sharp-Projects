using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    public class Employee<T> : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("This Employee Has Quit.");
        }

        public List<T> things { get; set; }

        public static Boolean operator == (Employee<T> emp1, Employee<T> emp2)
        {
            if (emp1.firstName != emp2.firstName)
            {
                return false;
            }
            else if(emp1.lastName != emp2.lastName)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Boolean operator != (Employee<T> emp1, Employee<T> emp2)
        {
            if (emp1.firstName != emp2.firstName)
            {
                return true;
            }
            else if (emp1.lastName != emp2.lastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
