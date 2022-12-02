using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // try and catch block
            try
            {
                // instantiated object
                Days day = new Days();
                Console.WriteLine("What day of the week is it?");
                // saves user input
                day.userDay = Console.ReadLine().ToString();

                // parses through Enum
                Day day1;
                bool checkParse = Enum.TryParse(day.userDay, out day1);

                if (checkParse == true)
                {
                    Console.WriteLine("Correct! That is the current day of the week.");
                }
                if (checkParse != true)
                {
                    Console.WriteLine("That is incorrect. Try again.");
                }
            }   
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
