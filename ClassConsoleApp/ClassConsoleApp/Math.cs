using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsoleApp
{
    // created class
    class Math
    {
        // void method with one parameter
        public void Operation(int number1)
        {
            // divides by 2 and displays to console
            int division = number1 / 2;
            Console.WriteLine(division);
        }  
        
        // declaring static method
        // overloading method
        // has out parameters
        public static void Operation(int number1, int number2, out int addition, out int subtraction)
        {
            addition = number1 + number2;
            subtraction = number1 - number2;
        }
    }
}
