using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;
    /*   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string fn, string ln, int id, int[] sc)
    {
        new Person(fn, ln, id);
        testScores = sc;
    }

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        char[] grade = new char[] { 'O', 'E', 'A', 'P', 'D', 'T' };
        int sum = 0;
        foreach (int i in testScores)
        {
            sum += i;
        }
        int a = sum / testScores.Length;

        if (a <= 100 && a >= 90)
            return grade[0];

        else if (a < 90 && a >= 80)
            return grade[1];

        else if (a < 80 && a >= 70)
            return grade[2];

        else if (a >= 55 && a < 70)
            return grade[3];

        else if (a >= 40 && a < 55)
            return grade[4];

        else
            return grade[5];

    }
}

class Solution {
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}