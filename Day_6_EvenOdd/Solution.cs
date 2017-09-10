using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
class Solution
{


    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int T = Convert.ToInt32(Console.ReadLine());
        string S = "";
        List<string> input = new List<string>();
        

        for (int i = 0; i < T; i++)
        {
            S = Console.ReadLine();
            input.Add(S);
        }

            foreach(string word in input)
            {
            for (int i = 0; i < word.Length; i += 2)
            {
                char[] evenOdd = word.ToCharArray();
                Console.Write(evenOdd[i]);
            }

            Console.Write(" ");

            for (int i = 1; i < word.Length; i += 2)
            {
                char[] evenOdd = word.ToCharArray();
                Console.Write(evenOdd[i]);
            }
            Console.WriteLine("");
            }

           }
    }