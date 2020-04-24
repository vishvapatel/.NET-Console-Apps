using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace duplicacyMania
{
    class Find_duplicacy
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());
            string inp = input.ToString().ToLower();
            List<Char> duplicate = new List<char>();
            int count = 0;
            bool flag = false;
            foreach(char i in inp)
            {
                foreach(char j in inp)
                {
                    if(i == j)
                    {
                        count += 1;
                    }
                    if(count > 1 && !duplicate.Contains(i))
                    {
                        flag = true;
                        duplicate.Add(i);
                    }
                }
                count = 0;
            }
            if (flag == false)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (char k in duplicate)
                {
                    Console.Write(k);
                }
            }
        }
    }
}
