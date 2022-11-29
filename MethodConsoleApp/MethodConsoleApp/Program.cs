using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // making variables known
            int num1;
            string num2;
            int result;

            // instantiates class
            MathOperation math = new MathOperation();

            // saves user's first number
            Console.WriteLine("Choose your first whole number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            // saves user input
            Console.WriteLine("Choose a second whole number.\nThis is optional. " +
                "Press enter if you would like a number chosen for you instead:");
            num2 = Console.ReadLine();

            // if the user does not enter a number, 12 will be the default number used
            if (string.IsNullOrEmpty(num2))
            {
                 num2 = "12";
            }

            // calls operation method
            result = MathOperation.Operation(num1, num2);

            // displays result to the console
            Console.WriteLine(num1 + " times " + num2 + " equals " + result);
            Console.ReadLine();



        }
    }
}
