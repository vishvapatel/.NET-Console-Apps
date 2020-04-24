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

class Solution {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string result = "";
        while(n > 1){
            int r = n % 2;
            result = Convert.ToString(r) + result;
            n /= 2;
        }
        result = Convert.ToString(n) + result;
        int cons_pairs = 0, max = 0, j;
        for(int i = 0; i < result.Count() - 1; i++){
            j = i+1;
            if(result[i] == '1' & result[j] == '1'){
                cons_pairs += 1;
            }
            if(result[i] == '1' & result[j] == '0'){
                if(cons_pairs >= max){
                    max = cons_pairs;
                }
                cons_pairs = 0;
            }
        }
        Console.WriteLine(max + 1);
    }
}
