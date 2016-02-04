// Count vowels in a text file
// Version 4: ToLower & string with accepted chars

using System;
using System.IO;


public class VowelsInTextFile4
{
    public static void Main(string[] args)
    {
        string nameFile, line;
        int countVowels = 0;
        string vowels = "aeiou";
        
        Console.Write("Enter the name of the text: ");
        nameFile = Console.ReadLine();
        StreamReader fileToRead = new StreamReader(nameFile);
        line = fileToRead.ReadLine();

        while(line!=null)
        {
            line = line.ToLower();
            for(int i=0;i<line.Length;i++)
            {
                if (vowels.Contains(line.Substring(i,1)))
                    countVowels++;
            }
            line = fileToRead.ReadLine();
        }

        fileToRead.Close();
        Console.WriteLine("The text has {0} vowels", countVowels);
    }
}
