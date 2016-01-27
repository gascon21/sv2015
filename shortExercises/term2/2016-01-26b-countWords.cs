// Words counter, three different ways

using System;
using System.IO;

public class WordsCounter
{
    static int CountWords(string s)
    {
        int count = 0;
        s = s.Trim();
        while (s.Contains("  "))
            s = s.Replace("  ", " ");
        string[] parts = s.Split(' ');
        count += parts.Length;
        return count;
    }
    
    static int CountWords2(string s)
    {
        int count = 0;
        string[] parts = s.Split(' ');
        foreach(string part in parts)
            if (part != "")
                count ++;
        return count;
    }
    
    static int CountWords3(string s)
    {
        int count = 0;
        s = s.Trim();
        for(int i=1; i<s.Length; i++)
            if ((s[i] == ' ')
                && (s[i-1] != ' '))
                    count++;
        count ++; // Last word
        return count;
    }
    
    
    public static void Main()
    {       
        Console.Write("Enter name of file:");
        string file = Console.ReadLine();
        StreamReader myfile = File.OpenText(file);
        int count = 0;
        string line = "";
        do
        {
            line = myfile.ReadLine();
            if (line != null)
            {
                count += CountWords(line);
            }

        } while (line != null);
        myfile.Close();
        Console.WriteLine("Number of words: {0}", count);
    }
}
