using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates first employee
            Employee employee1 = new Employee();
            employee1.FirstName = "Anna";
            employee1.LastName = "Summer";
            employee1.Id = 0014;

            // instantiates second employee
            Employee employee2 = new Employee();
            employee2.FirstName = "Branden";
            employee2.LastName = "Anderson";
            employee2.Id = 0026;

            // if statement to display either message
            if (employee1 == employee2)
            {
                Console.WriteLine("employee1 is equal to employee2");
            }
            else
            {
                Console.WriteLine("employee1 is not equal to employee2");
            }
            Console.ReadLine();
        }
    }
}
