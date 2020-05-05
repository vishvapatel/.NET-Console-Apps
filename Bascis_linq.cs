using System;
using System.Collections.Generic;
using System.Linq;

namespace linQ_in_Csharp
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(int id,string name, string dept)
        {
            ID = id;
            Name = name;
            Department = dept;
        }
    }
class Bascis_linq
{
    static void Main(string[] args)
    {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(1, "test", "D1"));
            emplist.Add(new Employee(2, "test1", "D2"));
            emplist.Add(new Employee(3, "test2", "D3"));
            emplist.Add(new Employee(4, "test3", "D1"));

            //Simple Query
            var result = from e in emplist
                         where e.Department == "D1"
                         select e;
            foreach(Employee emp in result)
            {
                Console.WriteLine($"Employee ID: {emp.ID}, Employee Name:{emp.Name}, Employee Department: {emp.Department}");
            }

            // using ORDER BY in the query
            Console.WriteLine("ORDER BY");

            var result1 = from e1 in emplist
                         where e1.Department == "D1"
                         orderby e1.Name ascending
                         select e1;
            foreach (Employee emp in result1)
            {
                Console.WriteLine($"Employee ID: {emp.ID}, Employee Name:{emp.Name}, Employee Department: {emp.Department}");
            }

            //using GROUP BY in the query
            Console.WriteLine("GROUP BY");
            var result2 = from e2 in emplist
                          where e2.Department == "D1"
                          group e2 by e2.Department; 
     
            foreach (var v in result2)
            {
                //here key = departmentS
                Console.WriteLine(v.Key); //key is the attribute on which grouping is done.
                 foreach(Employee emp in v)
                {
                    Console.WriteLine(emp.Name);
                }
            }


            //using functions like Count, max, min etc.
            Console.WriteLine("Count the number of employees in each department");
            var result3 = from e3 in emplist
                          group e3 by e3.Department into empdetails
                          select new { Dname = empdetails.Key, Dcount = empdetails.Count() }; //if u want to fetch all the details then use select empdetails
            foreach(var v in result3)
            {
                Console.WriteLine($" Department Name: {v.Dname}, Count: {v.Dcount}"); 
            }
        }
}
}
