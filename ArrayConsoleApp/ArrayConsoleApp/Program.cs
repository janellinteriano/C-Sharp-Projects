using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an array of strings
            string[] stringArray = { "pink", "blue", "purple", "red", "green", "yellow", "orange", "brown", "white", "black", "gray" };
            
            
            // creating an array of integers
            int[] numberArray = { 26, 12, 42, 53, 184, 9003, 18, 70, 869, 4035, 167 };

            // lets user choose number from index and displays chosen string 
            Console.WriteLine("Hello! First, pick a number 0-10 from the color array!");
            int userStrGuess = Convert.ToInt32(Console.ReadLine());

            if (userStrGuess <= 10)
            {
                Console.WriteLine("You picked the color: " + stringArray[userStrGuess] + "!");
                Console.ReadLine();
            }
            else
            {
                // if user chooses too high of an index number, it displays message in console
                Console.WriteLine("You picked too high of a number!");
                Console.ReadLine();
                return;
            }
            

            // lets user choose number from index and displays chosen integer 
            Console.WriteLine("Pick a number 0-10 from the number array!");
            int userNumGuess = Convert.ToInt32(Console.ReadLine());


            if (userNumGuess <= 10)
            {
                Console.WriteLine("You picked the number: " + numberArray[userNumGuess] + "!");
                Console.ReadLine();
            }
            else
            {
                // if user chooses too high of an index number, it displays message in console
                Console.WriteLine("You picked too high of a number!");
                Console.ReadLine();
                return;
            }

            // creating a list of strings
            string[] stringList = { "grape", "apple", "orange", "watermelon", "kiwi", "banana", "mango", "cranberry", "blueberry", "raspberry", "lime" };

            // lets user choose number from list index and displays chosen string 
            Console.WriteLine("Hello! First, pick a number 0-10 from the fruit list!");
            int userStrGuess2 = Convert.ToInt32(Console.ReadLine());

            if (userStrGuess2 <= 10)
            {
                Console.WriteLine("You picked the fruit: " + stringList[userStrGuess2] + "!");
                Console.ReadLine();
            }
            else
            {
                // if user chooses too high of an index number, it displays message in console
                Console.WriteLine("You picked too high of a number!");
                Console.ReadLine();
                return;
            }
        }
    }
}
