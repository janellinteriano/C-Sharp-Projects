using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // saves current DateTime as dt1
            DateTime dt1 = DateTime.Now;
            Console.WriteLine("Hello, today is " + dt1.ToString());
            Console.ReadLine();
            Console.WriteLine("Please enter a number:");
            // saves user input as int
            int answer = Convert.ToInt32(Console.ReadLine());
            // adds user number as hours to current DateTime
            DateTime dt2 = dt1.AddHours(answer);
            // prints to console
            Console.WriteLine("This is the time and date in " + answer + " hours.\n" + dt2);
            Console.ReadLine();
        }
    }
}
