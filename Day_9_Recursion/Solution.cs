using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int factorial(int N)
    {
        int factorial = N;
        for(int i = N-1; i > 0; i--)
        {
            factorial*=i;
        }
        return factorial;
    }

    static void Main(String[] args) {
       int N = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine(Solution.factorial(N));
    }
}
