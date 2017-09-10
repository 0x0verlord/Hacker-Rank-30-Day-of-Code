using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int maxCount = 0;

        string binary = Convert.ToString(n,2);
        foreach(char value in binary)
        {
            if(value == '1')
            {
                count++;
                maxCount = Math.Max(maxCount,count);
            }
           else
            {
                count = 0;
            }
        }
        Console.WriteLine(maxCount);


    }
}
