using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class student
    {
        int id;
        string name;
        string course;
        int mark;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Mark { get => mark; set => mark = value; }
        public string Course { get => course; set => course = value; }

        //public student(int id,string name, int mark, string course)
        /*{
            this.Id = id;
            this.Name = name;
            this.Mark = mark;
            this.Course = course;
        }*/

    }

    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            student s = new student();
           List<string> sobj = new List<string>(4);
           List<string> stud = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                try
                {
                    Console.Write($"Enter the ID of the {i}th student");
                    s.Id = Convert.ToInt32(Console.ReadLine());
                    sobj.Append(s.Id.ToString());
                    Console.Write($"Enter the name of the {i}th student");
                    s.Name = Console.ReadLine();
                    sobj.Append(s.Name);
                    Console.Write($"Enter the mark of the {i}th student");
                    s.Mark = Convert.ToInt32(Console.ReadLine());
                    sobj.Append(s.Mark.ToString());
                    Console.Write($"Enter the course of the {i}th student");
                    s.Course = Console.ReadLine();
                    sobj.Append(s.Course);
                    stud.Add(sobj.ToString());
                    sobj.Clear();
                }
                catch(Exception E)
                {
                    Console.WriteLine(E.Message);
                }
            }
            Console.Write("Enter the course to find");
            string course1 = Console.ReadLine();     
            Console.WriteLine($"Max marks in {course1} is of {showmax(stud, course1)}");   
        }
        public static string showmax(List<string> stud, string course)
        {
           
            int maxmks = 0;
            string name = string.Empty;
            foreach(string s in stud)
            {
                if(s.Course == course)
                {
                    if(s.Mark > maxmks)
                    {
                        maxmks = s.Mark;
                        name = s.Name;
                    }
                }

            }
            return name;
        }
    }
}
