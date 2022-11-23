using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {   
            //saves user input as yourName
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //concatenates all 4 strings and changes them to uppercase
            //then displays to console
            string str1 = "Hi ";
            string str2 = "! I hope you have ";
            string str3 = "a wonderful day!";
            string concatStr = str1 + yourName + str2 + str3;

            Console.WriteLine(concatStr.ToUpper());
            Console.ReadLine();


            // creates new StringBuilder and replaces each line with
            // the new string, then displays one line at a time in console
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello " + yourName + "!");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Replace("Hello " + yourName + "!", "Tomorrow is Thanksgiving day!");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Replace("Tomorrow is Thanksgiving day!", "Make sure to spend some time with family and friends.");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Replace("Make sure to spend some time with family and friends.", "Remember all the things you are grateful for.");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Replace("Remember all the things you are grateful for.", "And enjoy the Thankgiving feast!");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
