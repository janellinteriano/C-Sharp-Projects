using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // inherits from person class
    public class Employee : Person
    {
        // overrides and uses SayName() method
        public override void SayName()
        {
            base.SayName();
        }
    }
}
