using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    public class Employee
    {
        // setting properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        // chaining constructors and giving last name "Garcia" as default
        public Employee(string firstName, int Id) : this(firstName, "Garcia", Id)
        {
        }   
        
        public Employee(string firstName, string lastName, int Id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Id = Id;
        }
    }
}
