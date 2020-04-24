using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            List<Department> d = new List<Department>();

            Department dp1 = new Department(1, "HR", "BANGLORE");
            Department dp2 = new Department(2, "IT", "PUNE");
            Department dp3 = new Department(3, "SERVICES", "AHEMDABAD");
            d.Add(dp1);
            d.Add(dp2);
            d.Add(dp3);
            List<Department> emp_dp = new List<Department>();
            int option = 0;
            do
            {
                try
                {
                    Console.WriteLine("Select the option:");
                    Console.WriteLine("1: Add Employee");
                    Console.WriteLine("2: view Employee");
                    Console.WriteLine("3: update Employee");
                    Console.WriteLine("4: delete Employee");
                    Console.WriteLine("5: Exit");
                    Console.Write("Enter your option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string name = Console.ReadLine();
                            string desig = Console.ReadLine();
                            Console.Write("Enter the number of departments does employee belong to: ");
                            int depnum = Convert.ToInt32(Console.ReadLine());
                            int[] depid = new int[depnum];
                            for(int i=0; i < depnum; i++)
                            {
                                depid[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            foreach(int z in depid)
                            {
                                foreach (Department m in d)
                                {
                                    if (m.id == z)
                                    {
                                        emp_dp.Add(m);  
                                    }
                                }
                            }
                            Employee employee = new Employee(name, desig, emp_dp);
                            emp.Add(employee);
                            Console.WriteLine("Employee Added \n ");
                            break;

                        case 2:
                            Console.WriteLine("\t ID |  NAME |  DESIGNATION |  DPTNAME | LOCATION");
                            foreach (Employee e in emp)
                            {
                                Console.Write($"\t {e.id} |  {e.name} | {e.desig}| ");
                                foreach (Department de in e.dept)
                                {
                                    Console.Write($"[ {de.dp_name}  {de.dp_location} ]");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\n");
                            break;

                        case 3:
                            Console.Write("Enter the id to update");
                            int id = Convert.ToInt32(Console.ReadLine());
                            foreach(Employee e in emp)
                            {
                                if(e.id == id)
                                {
                                    Console.Write("What to update [name or desig]: ");
                                    string updatevalue = Console.ReadLine();
                                    if(updatevalue == "name")
                                    {
                                        Console.Write("Enter new name:");
                                        e.name = Console.ReadLine();
                                        Console.WriteLine("Name Updated \n");
                                        break;
                                    }
                                    if (updatevalue == "desig")
                                    {
                                        Console.Write("Enter new designation:");
                                        e.desig = Console.ReadLine();
                                        Console.WriteLine("Designation Updated \n");
                                        break;
                                    }
                                }
                            }
                            break;

                        case 4:
                            Console.Write("Enter the id to delete:");
                            int delid = Convert.ToInt32(Console.ReadLine());
                            foreach (Employee e in emp)
                            {
                                if (e.id == delid)
                                {
                                    emp.Remove(e);
                                    break;
                                }
                            }
                            Console.WriteLine("Employee Deleted \n");
                            break;
                        case 0:
                            Console.WriteLine("Please select valid option \n");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (option != 5);
            Console.WriteLine("Thank You!");
        }
    }
}
