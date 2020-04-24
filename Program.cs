using System;
using System.IO; //mandatory header file to perform IO operations.

namespace Exceptionhandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rdfile = null; //Object that reads the content of the file.
            try //try catch is required to handle the unknown wxception ehilr reading and excwessing the file.
            {
                rdfile = File.OpenText("../../../Confedential.txt"); //passing th efile location to be opened
                Console.WriteLine(rdfile.ReadToEnd()); //O/p all the contents of the file.
            }
            catch (FileNotFoundException nf) //Specific exception this block handles the exception.
            {
                Console.WriteLine(nf.Message);
            }
            catch(Exception ex) //if don't know the exact exception then can use general object Exception to handle the exception.
            {
                Console.WriteLine(ex.Message);
            }
            finally //Anything in this block is run even if exception occurs or not.
            {
                if (rdfile != null)
                {
                    rdfile.Close(); //Closes the object thus, stops reading the file.
                    Console.WriteLine("object closed");
                }
            }
        }
    }
}
