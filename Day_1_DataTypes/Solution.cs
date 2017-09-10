using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int num = Int32.Parse(Console.ReadLine());
        double dec = Double.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        Console.WriteLine(integer(i,num));
        Console.WriteLine(string.Format("{0:.0#}",deci(d,dec)));
        Console.WriteLine(stri(s,str));

    }

    static int integer(int i, int num)
    {   
        int sum = i + num;
        return sum;
    }
    static double deci(double d, double dec)
    {   
        double sum = d + dec;
        return sum;
    }
    static string stri(string s, string str)
    {
        string join = s + str;
        return join;
    }

}
