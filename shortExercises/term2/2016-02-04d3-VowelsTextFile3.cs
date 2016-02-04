// Count vowels in a text file
// Version 3: ToUpper & switch

using System;
using System.IO;

public class VowelsInTextFile3
{
    public static void Main(string[] args)
    {
        string nameFile, line;
        int countVowels = 0;
        
        Console.Write("Enter the name of the text: ");
        nameFile = Console.ReadLine();
        StreamReader fileToRead = new StreamReader(nameFile);
        line = fileToRead.ReadLine();
        while(line!=null)
        {
            line = line.ToUpper();
            for(int i=0;i<line.Length;i++)
            {
                switch(line[i])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        countVowels++;
                        break;
                }
            }
            line = fileToRead.ReadLine();
        }

        fileToRead.Close();
        Console.WriteLine("The text has {0} vowels", countVowels);
    }
}
