using System;
using System.Collections.Generic;

namespace studentDatabase
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }
        public string course { get; set; }

    }
    class Student_Database
    {
        static void Main(string[] args)
        {
            
            List<student> stud = new List<student>();
            int Id, Marks;
            string Name, Course;
            int n = Convert.ToInt32(Console.ReadLine());
            student[] s = new student[n];
            for (int i=0; i<n; i++)
            {
                try
                {
                    Id = Convert.ToInt32(Console.ReadLine());
                    Marks = Convert.ToInt32(Console.ReadLine());
                    Name = Console.ReadLine();
                    Course = Console.ReadLine();
                    s[i] = new student { id = Id, name = Name, marks = Marks, course = Course };
                    stud.Add(s[i]);
                }
                catch(Exception E)
                {
                    Console.WriteLine(E.Message);
                    break;
                }
            }
            string crse = Console.ReadLine();
            Console.WriteLine(showcase(stud, crse));
        }
        public static string showcase(List<student> stud, string course)
        {
            int max = 0;
            string name = string.Empty ;
            foreach(student s in stud)
            {
                if (s.course == course)
                {
                    if (s.marks > max)
                    {
                        max = s.marks;
                        name = s.name;
                    }
                }
            }
            return name;
        }
    }
}
