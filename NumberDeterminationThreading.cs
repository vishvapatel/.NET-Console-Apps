/*
 Author: Vishva Patel
 Github: .NET-Console-Apps 
 Program is based on MultiThreading in C#.

Question 2: Write a program which first generates a set of random numbers and then determines negative, positive even, positive odd numbers concurrently.
 
 */

using System;
using System.Threading;

namespace NumberDetermination
{
    class Numbers
    {
        private int[] arr = new int[10]; //Creating an array to generate numbers

        readonly Random r = new Random(); //Initializing Random class for random numbers.

        //This constructor intialzes array arr with random number from -100 to +100.
        public Numbers()
        {
            for(int i=0; i<10; i++)
            {
                
                arr[i] = r.Next(-100, 100);
            }
        }
        //This method is responsible fro checking whether the number is positive or negative.
        public void CheckSign()
        {
            foreach (int i in arr)
            {
                if(i < 0)
                    Console.WriteLine($"{i} is negative"); 
                else
                    Console.WriteLine($"{i} is Positive");
            }
        }
        //This method is responsible to determine whether the number is even or odd.
        public void CheckEvenOdd()
        {
           
            foreach (int i in arr)
            {
                if (i > 0) //Check only positive Even and Odd
                {
                    if (i % 2 == 0)
                        Console.WriteLine($"{i} is Even");
                    else
                        Console.WriteLine($"{i} is odd");
                }
            }
            
        }

    }
    class NumberDeterminationThreading
    {
        static void Main(string[] args)
        {

            Numbers num = new Numbers(); //Initializing the class.
            //Assigned methods to threads.
            Thread sign = new Thread(num.CheckSign); 
            Thread EvenOdd = new Thread(num.CheckEvenOdd); 

            try
            {
                //Starting thread.
                sign.Start();
                EvenOdd.Start();
            }catch(Exception e)
            {
                //Destroying thread.
                sign.Abort();
                EvenOdd.Abort();
            }
        }
    }
}
