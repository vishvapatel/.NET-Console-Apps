using System;
using System.Collections.Generic;
using System.Text;

namespace SignalTransmission
{
    class SignalTransmission
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            List<int> prime = new List<int>();
            int m, n;
            bool flag = true;
            foreach (string a in arr)
            {
                m = Convert.ToInt32(a);
                n = m / 2;
                for (int i = 2; i <= n; i++)
                {
                    if (m % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    prime.Add(m);
                }
            }
                prime.Sort();
                int suffix = prime[prime.Count - 2] + prime.Count;
                Console.WriteLine(suffix);
            
        }
    }
}
