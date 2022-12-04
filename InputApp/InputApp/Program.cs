using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\janel\mylog.txt"))
            {
                file.WriteLine(answer);
            }
        }
    }
}
