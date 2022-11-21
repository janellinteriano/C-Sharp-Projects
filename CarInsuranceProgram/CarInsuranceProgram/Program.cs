using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {   // start of program
            Console.WriteLine("Car Insurance Approval");
            Console.ReadLine();

            // gets user's age, DUI history, and speeding ticket amount
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            // converts user answer to boolean
            Console.WriteLine("Have you ever had a DUI? Please enter True or False.");
            bool duiHistory = Convert.ToBoolean(Console.ReadLine());

            // converts user answer to int
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // calculates if user is qualified
            bool qualifiedAge = userAge > 15;
            bool qualifiedHistory = duiHistory == false;
            bool qualifiedTickets = speedingTickets <= 3;

            bool qualifiedInsurance = qualifiedAge && qualifiedHistory && qualifiedTickets;

            // displays if user is qualified or not
            Console.WriteLine("Qualified?\n" + qualifiedInsurance);
            Console.ReadLine();

             


        }
    }
}
