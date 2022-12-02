using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates object
            Number number = new Number();
            // converts value to decimal form
            number.Amount = Convert.ToDecimal(12.75);

            //displays to console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
