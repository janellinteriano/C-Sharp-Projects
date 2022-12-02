using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    // created employee class
    public class Employee : IEquatable<Employee>
    {
        // set properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        // == operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {

            if (employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }

        // != operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }

        public bool Equals (Employee other)
        {
            return other.Id.Equals(this.Id);
        } 
    }
}
