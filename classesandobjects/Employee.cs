using System;
using System.Collections.Generic;
using System.Text;

namespace classesandobjects
{
    class Employee
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public Employee()
        {
            this.id = 0;
            this.name = string.Empty;
            this.salary = 0.0;
        }
         public double salaryHike(int per)
        {
            salary = (per / 100) * salary;
            return salary;
        }
    }
}
