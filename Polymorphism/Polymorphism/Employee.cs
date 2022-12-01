using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // created class and inherits from IQuittable
    public class Employee : IQuittable
    {
        // added to void method
         public void Quit()
        {
            Console.WriteLine("Thank you. You are free to go.");
        }
    }
}
