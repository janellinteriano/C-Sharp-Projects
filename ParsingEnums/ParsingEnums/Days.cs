using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    // created class
    public class Days
    {
        public Days day { get; set; }
        public string userDay { get; set; }
            
    } 

    // created Enum for days of the week
    public enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    

}
