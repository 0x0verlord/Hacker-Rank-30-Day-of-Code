using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        List<string> person = new List<string>();
        List<string> number = new List<string>();
        List<string> dictTemp = new List<string>();
        List<string> findName = new List<string>();
        List<string> phoneNum = new List<string>(phoneBook.Keys);


        for (int i = 0; i < n; i++)
        {

            string[] entry = Console.ReadLine().Split(' ');
            foreach (string word in entry)
            {
                dictTemp.Add(word);
            }
        }

        for (int i = 0; i < dictTemp.Count - 1; i += 2)
        {
            person.Add(dictTemp[i]);
        }

        for (int i = 1; i < dictTemp.Count; i += 2)
        {
            number.Add(dictTemp[i]);
        }


        for (int i = 0; i < person.Count; i++)
        {
            phoneBook.Add(person[i], number[i]);
        }

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            findName.Add(name);
        }

        foreach (string name in findName)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("{0}={1}", name, phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        /*Intial Code */
        //actually had to rewrite the code below since hackerrank's compiler didnt support(TryGetValue).
        //instead of using the try-catch, you can the code directly below. they both work
        /*for (int i = 0; i < phoneBook.Count; i++)
        {

            if (phoneBook.TryGetValue(findName[i], out string num))
            {
                Console.WriteLine("{0}={1}", findName[i], num);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }*/





    }


}







