// Count vowels in a text file
// Version 1: substrings

using System;
using System.IO;

public class VowelsInTextFile
{
    public static void Main()
    {
        StreamReader exercise;
        string name;
        string sentence;
        
        Console.WriteLine("Enter file name: ");
        name = Console.ReadLine();
        exercise = File.OpenText(name);

        sentence = exercise.ReadLine();
        int count = 0;

        while ( sentence != null )
        {
            for ( int c = 0; c < sentence.Length; c++)
            {
                if ( sentence.Substring(c,1) ==("a") ||
                    sentence.Substring(c,1) == ("A") ||
                    sentence.Substring(c,1) ==("e") ||
                    sentence.Substring(c,1) ==("E") ||
                    sentence.Substring(c,1) ==("i") ||
                    sentence.Substring(c,1) ==("I") ||
                    sentence.Substring(c,1) ==("o") ||
                    sentence.Substring(c,1) ==("O") ||
                    sentence.Substring(c,1) ==("u") ||
                    sentence.Substring(c,1) ==("U"))
                {
                    count++;
                }
            }
            sentence = exercise.ReadLine();
        }
        exercise.Close();
        Console.WriteLine("Number of vowels = {0}", count);
    }
}
