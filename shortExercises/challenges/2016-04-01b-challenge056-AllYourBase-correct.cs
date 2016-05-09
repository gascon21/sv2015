// Challenge 56: All your base
// https://code.google.com/codejam/contest/189252/dashboard#s=p0
// Original authors: Pablo Tárraga, Jose Miguel Durá
// Minor corrections by Nacho

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static int Analyze(string s)
    {
        int seconds = 0;

        Dictionary<char, int> dic = new Dictionary<char, int>();

        // First, let's find the base and the value for each symbol
        // First digit must be one, to be valid but as low as possible
        dic.Add(s[0], 1);
        bool firstValue = true;
        int countValues = 2;
        for (int i = 1; i < s.Length; i++)
        {
            if(!dic.ContainsKey(s[i]))
            {
                // Second digit must be 0
                if(firstValue)
                {
                    dic.Add(s[i], 0);
                    firstValue = false;
                }
                // Next digits must be 2, 3, 
                else
                {
                    dic.Add(s[i], countValues);
                    countValues++;
                }
            }
        }

        // Finally, let's process the result and find the
        // base 10 equivalent of the original number
        int numericBase = dic.Count;
        // Aliens don't use base 1
        if (numericBase == 1)
            numericBase++;
        int countBase = 0;
        for (int i = s.Length-1; i >= 0; i-- )
        {
            seconds += (int)Math.Pow(numericBase,countBase)*dic[s[i]];
            countBase++;
        }
        return seconds;
    }


    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=cases; i++)
        {
            string s = Console.ReadLine();
            Console.WriteLine("Case #"+i+": "+Analyze(s));        
        }
    }
}
