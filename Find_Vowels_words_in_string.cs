using System;
using System.Linq;
using System.Text;

namespace strings
{
    class Find_Vowels_words_in_string
    {
        static void Main(string[] args)
        { 
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int count =0 ;
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            for(int i =0; i < input.Length; i++)
            {
                foreach(char j in vowels)
                {
                    if(input[i] == j)
                    {
                        count+=1;  
                    }
                }
            }
            string firstword,substr, output="";
            foreach(string k in words)
            {
                substr = k.Substring(1).ToLower();
                firstword = k.Substring(0, 1).ToUpper();
                output = output + firstword + substr + " ";
            }
            Console.WriteLine(count);
            Console.WriteLine(words.Length);
            Console.WriteLine(output); 

            /*
            //String Builder examples
            StringBuilder sb = new StringBuilder(50);
            //Append value to the sb.
            sb.Append("ADO");
            Console.WriteLine(sb);
            Console.WriteLine("Apending value to string builder");
            sb.Append(".NET");
            Console.WriteLine(sb);
            Console.WriteLine("Inserting value a first index");
            sb.Insert(0, "Microsoft ");
            Console.WriteLine(sb);
            Console.WriteLine("Removing a value of length 7 from the string builder");
            sb.Remove(0, sb.ToString().IndexOf('A'));
            Console.WriteLine(sb);
           */
        }

    }
}
