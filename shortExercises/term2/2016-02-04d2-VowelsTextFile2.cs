// Count vowels in a text file
// Version 2: char & foreach

using System;
using System.IO;

public class VowelsInTextFile2
{
    public static void Main()
    {
        int numVowels=0;
        string line;
        
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();
        
        StreamReader myFile =  File.OpenText(name);
        
        do
        {
            line = myFile.ReadLine();
            if (line != null)
                foreach (char c in line)
                    if (c == 'A' || c == 'E' || c == 'I' 
                            || c == 'O' || c == 'U' 
                            || c == 'a' || c == 'e' 
                            || c == 'i' || c == 'o' || c == 'u')
                        numVowels++;

        }
        while (line != null);
        myFile.Close();
        
        Console.Write(numVowels);
    }
}
