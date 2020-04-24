using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    class Department
    {
        public int id { get; set; }
        public string dp_name { get; set; }
        public string dp_location { get; set; }

        public Department(int id, string name, string location)
        {
            this.id = id;
            dp_name = name;
            dp_location = location;
        }
    }
}
