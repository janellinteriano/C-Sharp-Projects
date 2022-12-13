using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolDbContext())
            {
                var s = new Student() 
                { StudentName = "Anna Mayfield" };

                db.Students.Add(s);
                db.SaveChanges();
            }
        }
    }
}
