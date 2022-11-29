using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    // created class "Math"
    class Math
    {
        // created 3 methods with same name "Operation"

        // takes user input as int and adds 5
        public static int Operation(int num1)
        {
            int answer;
            answer = num1 + 5;
            return answer;
        }   
        
        // takes user decimal and times by five
        // then returns as integer
        public static int Operation(decimal num2)
        {
            decimal answer;
            answer = num2 * 5;
            return Convert.ToInt32(answer);
        } 
        
        // takes user string and converts to integer
        // subtracts 1 from integer
        // returns answer as an integer
        public static int Operation(string num3)
        {
            int answer;
            answer = Convert.ToInt32(num3) - 1;
            return Convert.ToInt32(answer);
        }
    }
}
