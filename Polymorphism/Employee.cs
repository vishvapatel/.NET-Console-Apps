using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    class Employee
    {
        public static int _generateid = 1000;
        public int id { get; }
        public string name { get; set; }
        public string desig { get; set; }

        public List<Department> dept = new List<Department>(); 
        public Employee(string name, string desig, List<Department> depart)
        {
            id = ++_generateid;
            this.name = name;
            this.desig = desig;
            dept = depart;
        }
    }
}
