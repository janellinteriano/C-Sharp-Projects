using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // makes variables known
            int a, b;
            int c;
            int d;
            int e;

            // saves user input as "a"
            Console.WriteLine("Hello! Pick a number to do some math operations with:");
            a = Convert.ToInt32(Console.ReadLine());
            b = 100;
            c = Math.Add(a, b);
            d = Math.Subtract(a, b);
            e = Math.Multiply(a, b);
            
            // calls methods from Math class and displays answers to the console
            Console.WriteLine("100 plus " + a + " equals " + c);
            Console.WriteLine("100 minus " + a + " equals " + d);
            Console.WriteLine("100 times " + a + " equals " + e);
            Console.ReadLine();

        }
    }
}
