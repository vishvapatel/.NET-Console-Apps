using System;

namespace classesandobjects
{
    class Collection
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            manager emp = new manager();
            e.salary = 10000;
            Console.WriteLine(emp.salaryHike(10));
            Console.WriteLine(e.salaryHike(10));
        }
    }
}
