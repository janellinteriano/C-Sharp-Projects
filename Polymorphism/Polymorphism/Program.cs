using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // using polymorphism to create an object
            IQuittable employee = new Employee();
            // calling Quit() method
            employee.Quit();
            Console.ReadLine();
        }
    }
}
