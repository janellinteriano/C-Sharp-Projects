using System;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // start of program 
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // welcomes user 1 and grabs details from user input
            Console.WriteLine("Person 1: What is your hourly rate?");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Great! How many hours worked per week?");
            int person1HoursWorked = Convert.ToInt32(Console.ReadLine());


            // welcomes user 2 and grabs details from user input
            Console.WriteLine("Person 2: What is your hourly rate?");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Great! How many hours worked per week?");
            int person2HoursWorked = Convert.ToInt32(Console.ReadLine());


            // finds annual salary by multiplying hourly rate * hours worked
            // * 52 weeks, then displays to the console
            decimal user1Annual = person1HourlyRate * person1HoursWorked * 52;
            Console.WriteLine("The annual salary of Person 1 is $" + user1Annual);
            Console.ReadLine();


            // finds annual salary by multiplying hourly rate * hours worked
            // * 52 weeks, then displays to the console
            decimal user2Annual = person2HourlyRate * person2HoursWorked * 52;
            Console.WriteLine("The annual salary of Person 2 is $" + user2Annual);
            Console.ReadLine();


            // this finds out if person 1 has a greater salary than person 2
            // then displays "true or false" to the console
            bool trueOrFalse = user1Annual > user2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + trueOrFalse);
            Console.ReadLine();

        }  
    }
}
