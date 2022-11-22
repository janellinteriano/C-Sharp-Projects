using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {   
            // start of program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            // saves users answer as decimal
            Console.WriteLine("Please emter the package weight:");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            // if statement for first question in order to close console if item does weigh > 50 
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
            }

            // asks question and saves user inout as decimal
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            // calculates total of length, width, and height
            decimal dimentionTotal = packageLength + packageWidth + packageHeight;

            // multiplies dimentions, times the package weight, and finally divided by 100 for the user's quote
            decimal quote = packageHeight * packageLength * packageWidth * packageWeight / 100;

            // uses ternary operator to display if package is too big or the user's calculated quote
            string dimentionsResult = (dimentionTotal > 50) ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is: $" + quote;
            Console.WriteLine(dimentionsResult);
            
            // closes program
            Console.WriteLine("Thank you! Have a nice day.");
            Console.ReadLine();

        }
    }
}
