using System;
using System.Collections.Generic;
namespace Structure
{
    class Structure
    {
        struct Employee
        {
            public int empId, empExp;
            public double empPay;
            public double empPerformancePay;
            public string empName;

        }
        static void Main(string[] args)
        {
            Employee e;
            Console.Write("Enter the exprience of employee: ");
            e.empExp = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter the Id of employee: ");
            e.empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of employee: ");
            e.empName = Console.ReadLine();
            Console.Write("Enter the Pay of employee: ");
            e.empPay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the performance pay of employee: ");
            e.empPerformancePay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee Name: {0}", e.empName);
            Console.WriteLine("Employee Id: {0}", e.empId);
            Console.WriteLine("Employee Experience: {0}", e.empExp);
            Console.WriteLine("Gross Pay: {0}", calculateGrosspay(e.empPay, e.empPerformancePay));
            
        }
        public static double calculateGrosspay(double empPay, double performancePay)
        {
            double grosspay;
            grosspay = empPay + 0.15 * empPay + 0.20 * empPay + performancePay;
            return grosspay;
        }
        
    }
}
 