using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a list of integers
            var numberList = new List<int> { 12, 16, 20, 24, 36 };

            // try and catch block with foreach loop
            try
            {
                // saving user input as int
                Console.WriteLine("Enter a number you want to use to divide:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (var i in numberList)
                {
                    var answer = i / userNumber; 
                    Console.WriteLine(i + " divided by " + userNumber + " equals " + answer);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (SystemException)
            {
                Console.WriteLine("Please only enter a number.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
