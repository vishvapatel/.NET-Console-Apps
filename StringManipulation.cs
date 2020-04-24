using System;
using System.Collections.Generic;

namespace TCSXplorehands_On
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string dob = Console.ReadLine();
            bool valid = false;
            char[] alphabet = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',' ','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            foreach(char i in name)
            {
                foreach(char j in alphabet)
                {
                    if (i == j)
                    {
                        valid = true;
                    }
                }

            }
            string f_lower, l_lower,full_name;
            full_name = name[0] + "".ToUpper();
            full_name = full_name + name.Substring(1);

            string[] sp = name.Split(' ');
            f_lower = sp[0] + "".ToUpper();
            f_lower = f_lower + sp[0].Substring(1).ToLower();
            l_lower = sp[1] + "".ToUpper();
            l_lower = l_lower + sp[1].Substring(1).ToLower();
            int year = Convert.ToInt32(dob.Substring(6));
            int Age = 2019 - year;
            string category;
            if(Age > 0 && Age < 18)
            {
                category = "Minor";
            }
            else if(Age >=18 && Age < 55)
            {
                category = "Adult";
            }
            else
            {
                category = "Senior Citizen";
            }
            Console.WriteLine("{0}", full_name);
            Console.WriteLine("First Name:{0}", f_lower);
            Console.WriteLine("Last Name:{0}", l_lower);
            if(valid == true)
            Console.WriteLine("Name is Valid");
            else
                Console.WriteLine("Name is invalid");
            Console.Write("Age: {0},", Age);
            Console.Write(" Category: {0}", category);

            Console.ReadKey();
        }
    }
}