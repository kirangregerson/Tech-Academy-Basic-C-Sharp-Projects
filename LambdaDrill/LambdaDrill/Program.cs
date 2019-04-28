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
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp5 = new Employee();
            Employee emp6 = new Employee();
            Employee emp7 = new Employee();
            Employee emp8 = new Employee();
            Employee emp9 = new Employee();
            Employee emp10 = new Employee();

            emp1.firstName = "Joe"; emp1.lastName = "Dougherty"; emp1.ID = 1214;
            emp2.firstName = "Harry"; emp2.lastName = "Corbyn"; emp2.ID = 1336;
            emp3.firstName = "Fatima"; emp3.lastName = "Al-Khartuum"; emp3.ID = 1019;
            emp4.firstName = "Nathan"; emp4.lastName = "Farraday"; emp4.ID = 1717;
            emp5.firstName = "Roy"; emp5.lastName = "Bell"; emp5.ID = 1654;
            emp6.firstName = "Sarah"; emp6.lastName = "Hawthorne"; emp6.ID = 1004;
            emp7.firstName = "Joe"; emp7.lastName = "Morgan"; emp7.ID = 1967;
            emp8.firstName = "Jurgen"; emp8.lastName = "Burkhart"; emp8.ID = 1474;
            emp9.firstName = "Maurice"; emp9.lastName = "Galliway"; emp9.ID = 1115;
            emp10.firstName = "Sylvia"; emp10.lastName = "Rodriguez"; emp10.ID = 1583;

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);
            empList.Add(emp10);

            List<Employee> JoeList1 = new List<Employee>();
            foreach (Employee emp in empList)
            {
                if (emp.firstName == "Joe")
                {
                    JoeList1.Add(emp);
                }
            }
            List<Employee> JoeList2 = empList.Where(x => x.firstName == "Joe").ToList();
            List<Employee> idList = empList.Where(x => x.ID >= 1500).ToList();
            //the above list adds employees with ids above 1500 as the ids I chose are all between
            //1000 and 2000.
        }
    }
}
