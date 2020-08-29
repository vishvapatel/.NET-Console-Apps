using System;
using System.Collections.Generic;
using System.Linq;

namespace IRA4thAug
{
    class IRA4thAugust
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            manager.students.Add(new Student("Ravi", 17, 8, new int[4]{ 12, 30, 45, 60 }));
            manager.students.Add(new Student("Ram", 18, 8, new int[4] { 15, 33, 45, 60 }));
            manager.students.Add(new Student("Shyam", 16, 7, new int[4] { 12, 35, 45, 60 }));

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int age = Convert.ToInt32(Console.ReadLine());
                    List<Student> Agelist = manager.FindAge(age);
                    if(Agelist == null)
                    {
                        Console.WriteLine("No students found");
                    }
                    else
                    {
                        foreach(var s in Agelist)
                        {
                            Console.WriteLine($"{s.rollNo}, {s.name} from grade {s.grade}");
                        }
                    }
                    break;
                case 2:
                    int grade = Convert.ToInt32(Console.ReadLine());
                    List<Student> GetTop = manager.TopStudents(grade);
                    if(GetTop == null)
                    {
                        Console.WriteLine("No students found");
                    }
                    else
                    {
                        foreach(var s in GetTop)
                        {
                            Console.WriteLine($"{s.rollNo}, {s.name}, Average score:{s.Average}");
                        }
                    }
                    break;

            }
        }
    }
    class Student
    {
        public static int No = 1001;
        public int rollNo { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }
        public int[] Scores { get; set; }
        public double Average { get; set; }

        public Student(string nme, int ag, int gde, int[] scre)
        {
            rollNo = No;
            name = nme;
            age = ag;
            grade = gde;
            Scores = scre;
            Average = scre.Average();
            No++;
        }
    }


    class StudentManager
    {
        public List<Student> students = new List<Student>();

        public List<Student> FindAge(int age)
        {
            var CheckAge = students.Any(s => s.age == age);
            if (CheckAge)
            {
                IEnumerable<Student> GetStudentsQuery = from s in students
                                       where s.age == age
                                       select s;
                return GetStudentsQuery.ToList(); ;
            }
            else
            {
                return null;
            }
        }

        public List<Student> TopStudents(int grade)
        {
            var CheckGrade = students.Any(s => s.grade == grade);
            if (CheckGrade)
            {
                var GetStudentsQuery = (from s in students
                                       where s.grade == grade
                                       orderby s.Average descending
                                       select s).Take(2);
                return GetStudentsQuery.ToList();
            }
            else
            {
                return null;
            }

        }
    }
}

