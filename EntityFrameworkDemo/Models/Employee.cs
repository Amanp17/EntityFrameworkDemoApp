using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string FullName { get
            {
                return $"{FirstName} {LastName}";
            } 
        }
    }
}
