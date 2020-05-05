/*
 * Author: Vishva Patel
 * Github: .NET_Console_Apps
 * Assignment on Extension Methods in c# 
 *
Question 1: Write an extension method for integer, use the method to check if two numbers are equal.

Question 2: Write an extension method for string which counts the number of special charactes(&,#,$,@) in a given string
 */

using System;

namespace ExtensionMethods
{
    //Extension methods are static methods defined in a static class for any datatype or <IEnumerable> data structure which can be accessed using (.) operator.
    // They have the lowest prioirity while calling during compiling.
    //Extension method are identifies by 'this' keyword and is extended for the datatype post this keyword. 
    // All the other arguments are considered as method parameters and are nedded to be passed while extending.
    static class MyExtension
    {
        //Declaring & Defining an extension method.
        public static bool CheckEquality(this int a, int b) //Extension Method for type Integer to check equality.
        {
            return a == b ? true : false; //return true if equal or else return false.
        }
        public static int CountSpecialCharacters(this string str) //Extension Method for type Integer to count special characters in a string.
        {
            int count = 0;
            foreach(char i in str)
            {
                if (i == '&' || i == '#' || i == '.' || i == '@')
                    count++;
            }

            return count; //return count.
        } 
    } 
    class ExtensionMethod
    {
        static void Main(string[] args)
        {
            //Extending the extension function.

            // CheckEquality extension function.
            int a = 5, b = 5;
            Console.WriteLine($"a=5 and b=5: {a.CheckEquality(b)}"); //here we need to pass b because it will treat b as a method parameter.
            b = 6;
            Console.WriteLine($"a=5 and b=6: {a.CheckEquality(b)}");

            //CountSpecialCharacters extension function.
            string s = "Welcome to @extension methods & also.. #HappyLearning";
            Console.WriteLine($" # of Special Characters in {s} : {s.CountSpecialCharacters()}"); // As there is no additional parameter we do not need to pass additional parameter.
            s = "Hello World";
            Console.WriteLine($" # of Special Characters in {s} : {s.CountSpecialCharacters()}");

        }
    }
}
