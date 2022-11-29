using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates class                          
            MathOperation operation = new MathOperation();
            // calling parameters by name
            // passes in two numbers
            operation.Addition(num1: 9, num2: 10);
            Console.ReadLine();
        }
    }
}
