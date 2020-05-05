/*
 Author: Vishva Patel
 Github: .NET-Console-Apps 
 Program is based on MultiThreading in C#.

Question 1: Write a program which handles Push operation and Pop operation on stack concurrently.
 
 */


using System;
using System.Collections;
using System.Threading;

namespace MultiThreading
{
    class Stck
    {
       public Stack s = new Stack();
        public void PushElement()
        {

            s.Push(4);
            s.Push(5);
            Console.WriteLine($"Stack Push");
        }
        public void PopElement()
        {
            if (s.Count != 0)
            {
                s.Pop();
                Console.WriteLine($"Popped {s.Peek()} from stack");
            }
            
        }
    }
    class StackSimultaneous
    { 
        //There are total three threads created PushThread PopThread and the Main Thread.
        static void Main(string[] args)
        {
            Stck st = new Stck();
            Thread PushThread = new Thread(new ThreadStart(st.PushElement)); //There are two methods to initialize the thread using this ThreadStart delegate.
            Thread PopThread = new Thread(st.PopElement); //Another using this class instance method.
            try
            {
               
                PushThread.Start(); //Starting Thread
                PopThread.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(PushThread.Name + "Ended");
                PushThread.Abort(); //Destroying Thread
                Console.WriteLine(PopThread.Name + "Ended");
                PopThread.Abort(); //Destroying Thread.
            }
            Console.WriteLine("Main thread Ended"); //Main thread ends and program execution stops and all the cildren thread are auto destroyed.
        }
    }
}
