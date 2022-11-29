using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // making variables known
            int num1;
            decimal num2;
            string num3;
            int answer;

            // saves user input
            // instantiates class and calls first method
            Math obj = new Math();
            Console.WriteLine("Pick a whole number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            answer = Math.Operation(num1);

            // displays answer to the console
            Console.WriteLine(num1 + " plus 5 equals " + answer);
            Console.ReadLine();

            // saves user input
            // instantiates class and calls second method
            Math obj1 = new Math();
            Console.WriteLine("Pick a decimal number:");
            num2 = Convert.ToDecimal(Console.ReadLine());
            answer = Math.Operation(num2);

            // displays answer to the console
            Console.WriteLine(num2 + " times 5 equals " + answer);
            Console.ReadLine();

            // saves user input
            // instantiates class and calls third method
            Math obj2 = new Math();
            Console.WriteLine("Type in a whole number again:");
            num3 = Console.ReadLine();
            answer = Math.Operation(num3);

            // displays answer to the console
            Console.WriteLine(num3 + " minus 1 equals " + answer);
            Console.ReadLine();
        }    
    }
}
