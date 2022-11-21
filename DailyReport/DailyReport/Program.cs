using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing to the console
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Console.ReadLine(); will save the data entered into the vairable it is assigned to
            // this is for all examples below
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Convert.ToInt32(); casts the string data into a number
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Convert.ToBoolean(); casts the string data into a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Convert.ToInt32(); casts the string data into a number
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
