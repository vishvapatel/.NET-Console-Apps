using System;
using System.Collections.Generic; //Heaser file for the data structures.

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Lists in c#

            List<string> mylist = new List<string>(); //if you get an error, check to include the headerfile "System.Collection.Generic".

            //Adding elements to the list.

            mylist.Add("This");
            mylist.Add("is");
            mylist.Add("Sparta");
            mylist.Add("300");

            //Counting the length of the list
            Console.WriteLine("The length of mylist is {0}", mylist.Count);

            foreach (string l in mylist)
            {
                Console.Write(" " + l);
            }

            Console.WriteLine();
            //Removing element from the list

            mylist.Remove("300");

            foreach (string l in mylist)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------------------------

            //Arrays in c#

            string[] arr = new string[4] { "Brown", "Fox", "Jumped", "dogs" };
            foreach (string word in arr)
            {
                Console.Write(" " + word);
            }
            Console.WriteLine("Multidimensional arrays");

            //MUltidimensional arrays

            string[,] ar = new string[3, 2] { { "Mohit", "Radadiya" }, { "Hardik", "Patel" }, { "Ravi", "Patel" } };
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                int k = 0;
                Console.Write("{0} {1}", ar[i, k], ar[i, k + 1]);
                k++;
                Console.WriteLine();
            }
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------------------------

            //Queue in c#

            Queue<int> myQueue = new Queue<int>();

            //Adding elements to a queue
            myQueue.Enqueue(10);
            myQueue.Enqueue(100);
            myQueue.Enqueue(1000);
            myQueue.Enqueue(10000);
            myQueue.Enqueue(100000);

            //Printing a Queue
            Console.WriteLine("A Queue");
            foreach (int i in myQueue)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            //Count the elements in a queue.
            Console.WriteLine("The length of myQueue is: {0}", myQueue.Count);

            //Copying queue in an array
            int[] a = new int[myQueue.Count];
            myQueue.CopyTo(a, 0); //will copy the queue in an array
            Console.WriteLine("This is an array ");
            foreach (int j in a)
            {
                Console.Write(" " + j);
            }
            Console.WriteLine();
            //DeQueueing a Queue, Queue is built on hte principle of FIFO(First in First out)
            myQueue.Dequeue();
            Console.WriteLine("Dequeueed Queue");
            foreach (int i in myQueue)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            // Searching a Queue
            Console.WriteLine("Searching a Queue");

            if (myQueue.Contains(100))
            {
                Console.WriteLine("Found 100");
            }
            //Cleaing a queue
            myQueue.Clear();
            Console.WriteLine("Queue Cleared");

            //--------------------------------------------------------------------------------------------------------------------------------------

            // Stacks in C#

            Stack<int> St = new Stack<int>();
            Console.WriteLine("Stack");
            //Adding elelments to stack
            St.Push(10);
            St.Push(100);
            St.Push(1000);

            //Printing a Stack

            foreach (int i in St)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            //Count the elements in a stack.
            Console.WriteLine("The length of myQueue is: {0}", St.Count);

            //Copying stack in an array
            int[] sta = new int[St.Count];
            myQueue.CopyTo(sta, 0); //will copy the stack in an array
            Console.WriteLine("This is an array ");
            foreach (int j in sta)
            {
                Console.Write(" " + j);
            }
            Console.WriteLine();
            //Poping a stack, Stack is built on the principle of LIFO(Last in First out)
            St.Pop();
            Console.WriteLine("popped Stack");
            foreach (int i in St)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            // Searching a Stack
            Console.WriteLine("Searching a Stack");

            if (St.Contains(100))
            {
                Console.WriteLine("Found 100");
            }
            //Clearing a stack
            St.Clear();
            Console.WriteLine("Stack Cleared");

            //-------------------------------------------------------------------------------------------------------------------------------

            //Linkedlists in c#
            LinkedList<int> ll = new LinkedList<int>();
            
            //Adding elements to the linkedlist.
            ll.AddFirst(10);
            ll.AddLast(100);
            ll.AddFirst(5);
            ll.AddLast(150);
            Console.WriteLine("Linked list");
            
            //Printing the list
            foreach (var i in ll)
            {
                Console.Write("{0} ->", i);
            }
            Console.WriteLine();

            //Finding the node of th eelement of the list

            LinkedListNode<int> n = ll.Find(10);

            //Different way of adding to a linked list
            Console.WriteLine("Adding an Element 20");
            ll.AddAfter(n, 20);

            Console.WriteLine("Removing 10 from the list");

            ll.Remove(10);

            //Printing the updated list

            foreach (var i in ll)
            {
                Console.Write("{0} ->", i);
            }
            Console.WriteLine();
        }
    }
}
