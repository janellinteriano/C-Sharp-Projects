using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables 
            int AdditionResult, SubtractionResult;
            int number2 = 2; 
            
            // instantiates class
            Math math = new Math();

            // saves user input as number1
            Console.WriteLine("Please enter a whole number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // calls first void method
            math.Operation(number1);
            Console.ReadLine();

            // calls second method with out parameters
            // displays to console
            Math.Operation(number1, number2, out AdditionResult, out SubtractionResult);
            Console.WriteLine($"{number1} + {number2} equals {AdditionResult}. {number1} - {number2} equals {SubtractionResult}.");
            Console.ReadLine();
        }
    }
}
