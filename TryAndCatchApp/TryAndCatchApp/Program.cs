using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // try and catch block
            try
            {
                int thisYear = 2022;
                Console.WriteLine("Hello! How old are you?");
                // saves user input as int
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer >= 0)
                {
                    int year = thisYear - answer;
                    Console.WriteLine($"You were born in the year: {year}");
                }
                else
                {
                    // displays if user enter a number less than 0
                    Console.WriteLine("You must enter a positive whole number.");
                }
            }
            catch (Exception)
            {
                // displays message for general exception
                Console.WriteLine("You have entered something incorrect.");
            }
            Console.ReadLine();
        }
    }
}
