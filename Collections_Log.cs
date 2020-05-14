/*
 *Author: Vishva Patel
 * Program: TCS C# hands-on Collections
 * Github: .NET-Console-Apps
 */

using System;
using System.Collections;


namespace Contestantlog
{
    class Collections_Log
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            ArrayList names = new ArrayList(n); //This will store the contestant log, instead of array list one can use string array 
            //as well but this collection comes with predefined extensions.
            int[] count = new int[n]; //This stores the count of the completed task by each contestant.
            string value; //variable to store the contestant log.
            int j, max = 0; //j is the link between both arrays, max is to find out the number of task completed by the winner(s).

            //This loop takes input and also performs the necessary operations accordingly.
            for (int i = 0; i < n; i++)
            {
                value = Console.ReadLine();
                //we need to first add something before iterating or checking the name.
                if (i > 0)
                {
                    if (names.Contains(value)) //if name is already in the list then no need to add again only increment the count.
                    {
                        j = names.IndexOf(value); //Finding the index of the name, this is responsiblefor keeping the list in sync.
                        count[j]++; //incrementing the count.
                    }
                    //What happens if the new name is added to log.
                    else
                    {
                        names.Add(value); //first add the name to the list
                        j = names.IndexOf(value); //Find the index to which it is added which will by default be the next index to previous names index.
                        count[j] = 1; //setting the count as 1 as it has completed one task.
                    }
                }
                //This block adds the first name.
                else
                {
                    names.Add(value);
                    j = names.IndexOf(value);
                    count[j] = 1;
                }
            }
            //There can be multiple winners as well with same number of tasks completed.
            foreach (int c in count)
            {
                if (c >= max)
                {
                    max = c; //getting the maximum value of the task completed.
                }
            }

            //printing the names of contestants who have completed the max tasks and are winners.
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == max)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}

//Sample outputs:
/* Test Case 1
     4           
     john
     harry
     john
     harry
     -----o/p
     john
     harry   
 
  Test case 2
     7
     ram
     rajesh
     ravi
     kunal
     pravina
     uma
     hari
     ------o/p
     ram
     rajesh
     ravi
     kunal
     pravina
     uma
     hari


 */
