using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates objects

            List<Employee> EmployeeList = new List<Employee>();
            List<Employee> JoeList = new List<Employee>();

            EmployeeList.Add(new Employee { FirstName = "Anna", LastName = "Smith", Id = 1 });
            EmployeeList.Add(new Employee { FirstName = "Dawn", LastName = "May", Id = 2 });
            EmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Garcia", Id = 3 });
            EmployeeList.Add(new Employee { FirstName = "Lisa", LastName = "Marie", Id = 4 });
            EmployeeList.Add(new Employee { FirstName = "Branden", LastName = "Shultz", Id = 5 });
            EmployeeList.Add(new Employee { FirstName = "Renee", LastName = "Austin", Id = 6 });
            EmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Peterson", Id = 7 });
            EmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Nevada", Id = 8 });
            EmployeeList.Add(new Employee { FirstName = "Mary", LastName = "Aniston", Id = 9 });
            EmployeeList.Add(new Employee { FirstName = "Johanna", LastName = "Castillo", Id = 10 });

            // foreach loop grabs employees with first name "Joe"
            // and adds them to new list
            foreach (Employee employee in EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }

            // displays list
            foreach (Employee employee in JoeList)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.ReadLine();

            // same action with Lambda expression
            List<Employee> newList = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            // foreach loop to display names in new list
            foreach(Employee employee in newList)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.ReadLine();

            // another lambda expression
            List<Employee> idList = EmployeeList.Where(x => x.Id > 5).ToList();

            // foreach loop to display employees with id greater than 5
            foreach(Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.ReadLine();   
        }
    }
}

