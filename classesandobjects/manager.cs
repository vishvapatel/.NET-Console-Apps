using System;
using System.Collections.Generic;
using System.Text;

namespace classesandobjects
{
    class manager:Employee
    {
        public manager() : base()
        {}

        public double salaryHike(int per)
        {
            per += 10;
            salary = salary + (10 / 100) * salary;
            return salary;
        }

    }
}
