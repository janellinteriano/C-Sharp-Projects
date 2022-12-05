using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating object
            Employee employee = new Employee("Janell", 1226);
            // setting constant string
            const string greeting = "Hello! welcome to your first day on the job ";
            Console.WriteLine($"{greeting}{employee.firstName}!");
            Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            // saves user input as int
            var favoriteNumber = Convert.ToInt32(Console.ReadLine());
            // displays message to console
            Console.WriteLine($"Okay. Your employee Id number is {employee.Id} and your favorite color is {favoriteNumber}!");
            Console.ReadLine();
            
            
        }
    }
}
