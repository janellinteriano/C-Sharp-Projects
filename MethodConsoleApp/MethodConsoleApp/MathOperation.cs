using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleApp
{
    // created class MathOperation
    class MathOperation
    {
        // enters parameters, one int, one string
        public static int Operation(int num1, string num2)
        {
            int result; 
            // converts user string to int if number is entered
            result = num1 * Convert.ToInt32(num2);
            // returns int result
            return result;
        }
    }
}
