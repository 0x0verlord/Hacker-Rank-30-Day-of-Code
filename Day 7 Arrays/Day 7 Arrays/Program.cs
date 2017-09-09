using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Arrays
{
    class Solution
    {

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            Solution.ConvertAll(arr_temp, n);


        }

        static void ConvertAll(string[] arr_temp, int arr_length)
        {
            List<int> newArray = new List<int>();
            for (int i = arr_length - 1; i >= 0; i--)
            {
                newArray.Add(Int32.Parse(arr_temp[i]));
            }
            foreach (int num in newArray)
            {
                Console.Write(num);
                Console.Write(" ");
            }

        }
    }
}


    
