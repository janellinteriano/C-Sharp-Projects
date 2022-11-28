using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    // created class Math
    public class Math
    {
        
        // created 3 methods Add, Subtract, and Multiply
        // takes in parameters and returns integer
        public static int Add(int number1, int number2)
        {
            int total;
            total = number1 + number2;
            return total;
        } 
        
        public static int  Subtract(int number1, int number2)
        {
            int difference;
            difference= number2 - number1;
            return difference;
        }

        public static int Multiply(int number1, int number2)
        {
            int product;
            product = number1 * number2;
            return product;
        }
    }
}
