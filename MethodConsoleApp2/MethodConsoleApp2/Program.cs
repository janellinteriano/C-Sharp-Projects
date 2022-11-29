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
            // passes in two numbers
            operation.Addition(9, 10);
            // passes in two numbers
            // calling parameters by name
            operation.Addition(num1: 20, num2: 13);
        }
    }
}
