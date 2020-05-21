/* 
 Author: vishva patel
 Program: TCS OPA C# hands-On
 Please find the pic for the problem statement.
*/
using System;
using System.Collections.Generic;
using System.Text;
namespace XploreOPA
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Pre written code by hackerrank.
            List<department> dept = new List<department>
            {
                new department(){departmentid=1, dept_Name="EEE", dept_location="Mumbai"},
                new department() { departmentid = 2, dept_Name = "ECE", dept_location = "Chennai" },
                new department() { departmentid = 3, dept_Name = "CSE", dept_location = "Mumbai" },
                new department() { departmentid = 4, dept_Name = "IT", dept_location = "Chennai" }
            };
            
            //Given in the prewritten code.
            List<student> studentlist = new List<student>();
            studentlist.Add(new student("Priya", 23, 1));
            studentlist.Add(new student("Madhu", 25, 2));
            studentlist.Add(new student("Asha", 24, 1));
            studentlist.Add(new student("Arpit", 23, 1));
            studentlist.Add(new student("Bhavik", 25, 4));
            studentlist.Add(new student("Kamala", 23, 2));

            Dictionary<int, int> count = new Dictionary<int, int>(); // To maintain the strength of 3 in each department, will be checked while adding students.
            count.Add(1, 3); //Key = department id and value = Number of students which cannt exceed 3 in each department.
            count.Add(2, 2);
            count.Add(3, 0);
            count.Add(4, 1);

            int choice = Convert.ToInt32(Console.ReadLine()); //Choice to perform operatioin.
            try
            {
                switch (choice)
                {
                    //Viewing the number of students according to the format.
                    case 1:
                        string nme = string.Empty;
                        string location = string.Empty;
                        foreach (student s in studentlist)
                        {
                            foreach (department d in dept)
                            {
                                if (s.st_dept_id == d.departmentid)
                                {
                                    nme = d.dept_Name;
                                    location = d.dept_location;
                                }
                            }
                            Console.WriteLine($"{s.st_Name}({s.st_age}) - Deapartment : {nme},{location}");
                        }
                        break;

                    //Adding to the department.
                    case 2:
                        string name = Console.ReadLine();
                        int age = Convert.ToInt32(Console.ReadLine());
                        string dept_name = Console.ReadLine();
                        string dept_loc = Console.ReadLine();
                        int dept_id = 0;
                        bool flag = false;
                        foreach (department d in dept)
                        {
                            if (d.dept_Name == dept_name && d.dept_location == dept_loc)
                            {

                                dept_id = d.departmentid;
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            Console.WriteLine("Department does not exist");
                            break;
                        }
                        if (age < 18)
                        {
                            Console.WriteLine($"{name} is too young to join");
                            break;
                        }
                        if (age > 25)
                        {
                            Console.WriteLine($"{name} is too old to join");
                            break;
                        }

                        if (flag == true)
                        {
                            if (count[dept_id] == 3)
                            {
                                Console.WriteLine("Student limit excedded");
                            }
                            else
                            {
                                studentlist.Add(new student(name, age, dept_id));
                                count[dept_id]++;
                                Console.WriteLine($"{name} has been added successfully");
                                foreach (student s in studentlist)
                                {
                                    foreach (department d in dept)
                                    {
                                        if (s.st_dept_id == d.departmentid)
                                        {
                                            name = d.dept_Name;
                                            dept_loc = d.dept_location;
                                        }
                                    }
                                    Console.WriteLine($"{s.st_Name}({s.st_age}) - Deapartment : {name},{dept_loc}");
                                }
                            }
                        }
                        break;
                }
            }catch(Exception e)
            {
                string msg = e.ToString();
            }
        }

    }

    class department
    {
        public int departmentid { get; set; }
        public string dept_Name { get; set; }
        public string dept_location { get; set; }
    }

    class student
    {
        public string st_Name { get; set; }
        public int st_age { get; set; }
        public int st_dept_id { get; set; }

        public student(string name, int age, int id)
        {
            st_Name = name;
            st_age = age;
            st_dept_id = id;
        }

    }
}
