using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int multiple = 0;
        for (int i = 1; i < 11;i++)
        {
            multiple = n*i;
            Console.WriteLine(n+" x "+i+" = "+multiple);
        }
        
    }
}