using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // this lets user input their own number
            Console.WriteLine("Hello! Please enter your first number.");
            int yourNumber1 = Convert.ToInt32(Console.ReadLine());


            // this multiplies the user's number by 50 and displays to the console
            int newNum1 = yourNumber1 * 50;
            Console.WriteLine(yourNumber1 + " times 50 equals " + newNum1);
            Console.ReadLine();


            // this lets user input their own number
            Console.WriteLine("Please enter your second number.");
            int yourNumber2 = Convert.ToInt32(Console.ReadLine());


            // this adds the user's number by 25 and displays to the console
            int newNum2 = yourNumber2 + 25;
            Console.WriteLine(yourNumber2 + " plus 25 equals " + newNum2);
            Console.ReadLine();


            // this lets user input their own number
            Console.WriteLine("Please enter your third number.");
            int yourNumber3 = Convert.ToInt32(Console.ReadLine());


            // this divides the user's number by 12.5 and displays to the console
            double newNum3 = yourNumber3 /12.5;
            Console.WriteLine(yourNumber3 + " divided by 12.5 equals " + newNum3);
            Console.ReadLine();


            // this lets user input their own number
            Console.WriteLine("Please enter your fourth number.");
            int yourNumber4 = Convert.ToInt32(Console.ReadLine());


            // this compares the user's number to 50 and displays to the console
            // whether it is greater than 50 using true or false
            bool newNum4 = yourNumber4 > 50;
            Console.WriteLine("True or False: " + yourNumber4 + " is greater than 50. \n" + newNum4 + "!");
            Console.ReadLine();


            // this lets user input their own number
            Console.WriteLine("Please enter your fifth number.");
            int yourNumber5 = Convert.ToInt32(Console.ReadLine());


            // this divides the user's number by 7 and displays the remainder to the console
            int newNum5 = yourNumber5 % 7;
            Console.WriteLine(yourNumber5 + " divided by 7 has a remainder of " + newNum5);
            Console.ReadLine();
        }
    }
}
