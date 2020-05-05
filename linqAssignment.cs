/*
 * Question:
Create a class Student with below attributes.
string - name
int - roll number
structure - subject marks (in order of English, Mathematics, Science and History)

Create public properties and Create a constructor which takes all parameters in the above sequence.
The constructor should set the value of attributes to parameter values inside the constructor.

Given a list of Student objects. Write code to perform the following tasks:
1. Find and display the first three rank holder details. 
   If two people in the top three positions have the same aggregate marks, skip next rank.
2. Display the student details according to their ranks.
3. Find and display the details of all subject toppers.

Note: Implement using LINQ 

Author: Vishva patel
Topic: Language-Integrated Query (LINQ) in C#.
*/




using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Assignment
{
    class Student
    {
        public string Name { get; set; }
        public int rollno { get; set; }
        //As given in assignment
        public struct Scores
        {
            public double English_mks;
            public double Maths_mks;
            public double Science_mks;
            public double History_mks;
        }

        public Scores s;
        
        public Student(string name, int roll, double eng_mks, double math_mks, double Sci_mks, double Hist_mks)
        {
            Name = name;
            rollno = roll;
            s.English_mks = eng_mks;
            s.Maths_mks = math_mks;
            s.Science_mks = Sci_mks;
            s.History_mks = Hist_mks;
        }
        
    }

    class linqAssignment
    {

        static void Main(string[] args)
        {
            
            //Some Console features to play with
            Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = true;


            List<Student> studentlist = new List<Student>();
            //Marks are calculated out of 50.
            //Topper is decided with the highest average of all scores.
            studentlist.Add(new Student("Ravi", 146, 40, 49, 36, 45));
            studentlist.Add(new Student("Khushboo", 107, 40, 39, 45, 47));
            studentlist.Add(new Student("Ram", 154, 45, 37, 36, 45));
            studentlist.Add(new Student("Mohit", 123, 43, 39, 38, 35));
            studentlist.Add(new Student("Hardik", 132, 20, 29, 39, 40));
            studentlist.Add(new Student("Laxman", 101, 30, 39, 46, 45));
            //Question: 1 Display
            var Rank = (from std in studentlist
                        let avg = (std.s.English_mks + std.s.Maths_mks + std.s.Science_mks + std.s.History_mks) / 4
                        orderby avg descending
                        select new { std.Name, std.rollno, avg }).Take(3);
            //Display top three rank holders
            Console.WriteLine("Top 3 Rank holders:");
            int k = 1;
            foreach (var r in Rank)
            {
                Console.WriteLine($"Rank {k} : {r.Name} - roll no {r.rollno}");
                k++;
            }

            //Question: 2 Display the student details according to their ranks.
            Console.WriteLine("Rank List");
            var disp_details = from std in studentlist
                               let avg = (std.s.English_mks + std.s.Maths_mks + std.s.Science_mks + std.s.History_mks) / 4
                               orderby avg descending
                               select std;
            k = 1;
            foreach (var d in disp_details)
            {
                Console.WriteLine($"[ Rank {k}: {d.Name}  Roll No: {d.rollno} ] => ( English: {d.s.English_mks}, Maths: {d.s.Maths_mks}, Science: {d.s.Science_mks} History: {d.s.History_mks})");
                k++;
            }

            //Question: 3 Display Subject wise toppers.

            //Query As we are assigned to use structure, it is not an <IEnumreable> type but it is a value type thus,
            //linq can't work on it. Hence, we need to take one at a time. 

            Console.WriteLine("Subject Wise Toppers:");

            //Getting English Topper
            var English_mks = (from std in studentlist
                               orderby std.s.English_mks descending
                               select std).Take(1);
            foreach (var e in English_mks) {
                Console.WriteLine($"English: {e.Name}");
            }

            //Getting Maths Topper
            var math_mks = (from std in studentlist
                               orderby std.s.Maths_mks descending
                               select std).Take(1);
            foreach (var e in math_mks)
            {
                Console.WriteLine($"Maths: {e.Name}");
            }
            
            //Getting Science Topper
            var science_mks = (from std in studentlist
                               orderby std.s.Science_mks descending
                               select std).Take(1);
            foreach (var e in science_mks)
            {
                Console.WriteLine($"Science: {e.Name}");
            }
            
            //Getting History Topper
            var History_mks = (from std in studentlist
                               orderby std.s.History_mks descending
                               select std).Take(1);
            foreach (var e in History_mks)
            {
                Console.WriteLine($"History: {e.Name}");
            }

        }
    }
}
