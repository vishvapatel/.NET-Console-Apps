using System;

namespace Ransomization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counting unique random numbers upto 100 in an array.
            int[] arr = new int[100];
            bool addtoarray = true;
            int k = 0, randomnumber;
            Random r = new Random();
            while(k < 100)
            {
                randomnumber = r.Next(1, 101);
                addtoarray = true;
                for(int l = 0; l < k; l++)
                {
                    if(arr[l] == randomnumber)
                    {
                        addtoarray = false;
                        break;
                    }
                }
                if(addtoarray == true)
                {
                    arr[k] = randomnumber;
                    k++;
                }
            }
            Console.WriteLine("Length: {0}", arr.Length + Environment.NewLine);
            foreach(int j in arr)
            {
                Console.Write("{0}, ", j);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }
    }
}
