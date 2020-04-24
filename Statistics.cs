using System;
using System.Collections.Generic;

namespace csharp_tutorials
{
    class Statistics
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[n];
            int sum = 0;
            float mean;
            for (int i=0; i < n; i++){
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(input);
            foreach(int j in input)
            {
                sum += j;
            }
            mean = sum / n;
            Console.WriteLine("Mean: {0}", mean);
            int median;
            if(n % 2 == 0)
            {
                median = input[n / 2]; 
                int median2 = input[n / 2 - 1];
                Console.WriteLine("Median: {0} {1}", median, median2);
            }
            else
            {
                median = input[n / 2];
                Console.WriteLine("Median: {0}", median);
            }
            int mode = 0, count = 0, number = 0 ;
            foreach (int j in input)
            {
                foreach (int k in input)
                {
                    if (k == j)
                    {
                        count += 1;
                    }
                    if (count > number)
                    {
                        number = count;
                        mode = j;
                    }
                }
                count = 0;
            }
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Mode: {0}", mode);
        }
    }
}
