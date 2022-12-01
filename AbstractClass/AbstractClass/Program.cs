using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the object
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // calling the SayName() method
            // on the object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
