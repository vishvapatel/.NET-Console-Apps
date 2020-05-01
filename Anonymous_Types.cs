/* 
 Author: Vishva Patel
 Github: .NET_Console_Apps
 problem: Anonymous Types in C#
 
  */

using System;

namespace Anonymus_Types
{
    class Anonymous_Types
    {
        static void Main(string[] args)
        {

            // Basics of Anonymous types-------------------------------------------------------------------- 
         
            // Declaring Anonymous type => used when datatype is not fixed or want to process multiple data properties.
            var anymn_type = new { Error_code = "2046", Message = "This is an anonymous type"};
            // Printing/calling an anonymous type
            Console.WriteLine($"{anymn_type.Error_code} => {anymn_type.Message}");


            //Declaring an array of anonymous types
            var anymn_arr = new[] { new {Error_code = "2014", Message = "Divide by Zero" }, new { Error_code = "2015", Message = "Use of unassigned variable" } };
            //Printing/calling a anonymous type array
            foreach(var an in anymn_arr)
            {
                Console.WriteLine($"{an.Error_code} => {an.Message}");
            }


            //Declaring a Nested anonymous type
            var anym_type = new { Error_code = "3057", Message = "Outer message", type = new { Error_type = "Warning"} };
            //Printing/calling an anonymous type
            Console.WriteLine($"{anym_type.Error_code} => {anym_type.Message}, Type = {anym_type.type.Error_type}");
        


            //-----------------------------------------------------------------------------------------

            //Solutions to assignment problems in AsCEnD_DotNet_Advanced Course on Xplore

            //Question -1 WAP to assign and display Name, Salary and DepartmentName of the employee using anonymous type.

            string Name = Console.ReadLine();
            string Department  =Console.ReadLine();
            double Salary = Convert.ToDouble(Console.ReadLine());
            
            var empdetails = new { Empname = Name, EmpSalary = Salary, EmpDept = Department};
            Console.WriteLine($"Employee Name: {empdetails.Empname}, Employee Salary: {empdetails.EmpSalary},Employee Department: {empdetails.EmpDept}");

            //Question -2 WAP to create an array of employees using anonymous type.

            var Employee = new[] { new {empname = "Arjun", empdept = "IT" },new { empname = "Bheem", empdept = "Logistics"} };
            foreach(var v in Employee) {

                Console.WriteLine($"Employee Name: {v.empname},Employee Department: {v.empdept}");
            }

            //Question -3 WAP that stores Employee Name, salary, department and location using nested anonymous type.

            var Employee_Details = new { name = "Sahadev", Dept = "Marketing", salary = 120000, location = new { state = "Bharatvarsh", city = "Indraprasth" } };
            Console.WriteLine($"Employee Name: {Employee_Details.name}, Employee Salary: {Employee_Details.salary},Employee Department: {Employee_Details.Dept}, Employee Location: {Employee_Details.location.city}, {Employee_Details.location.state}");

        }
    }
}
