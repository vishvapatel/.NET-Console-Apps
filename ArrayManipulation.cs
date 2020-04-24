using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{



    static void Main(string[] args)
    {
        int[][] arr = new int[6][];
        int first, second, third, fourth, fifth, sixth, seven, sum =0, max = 0, k=1;
        int[] sumation = new int[20];
        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                first = arr[i][j];
                second = arr[i][j + 1];
                third = arr[i][j + 2];
                fourth = arr[i + 1][j + 1];
                fifth = arr[i + 2][j];
                sixth = arr[i + 2][j + 1];
                seven = arr[i + 2][j + 2];
                sum = first + second + third + fourth + fifth + sixth + seven;
                //Console.WriteLine(sum);
                if(sum < 0)
                {
                    if(k == 1)
                    {
                        max = sum;
                        k++;
                    }
                    if(sum > max)
                    {
                        max = sum;
                    }

                }
                else
                {
                    if(sum > max)
                    {
                        max = sum;
                        k++;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}
