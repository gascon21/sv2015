// Count vowels in a binary file
// Version 2: Reading the whole file into an array

using System;
using System.IO;

public class VowelsBinary2
{
    public static void Main()
    {
        Console.WriteLine("Enter file name: ");
        string name = Console.ReadLine();
        
        FileStream myFile = File.OpenRead(name);
        byte [] data = new byte [myFile.Length];
        
        int position = 0;
        int amountToRead = (int) myFile.Length;
        int amountRead;
        
        amountRead = myFile.Read(data, 
            position,amountToRead);
        myFile.Close();
        
        int count = 0;

        for ( int i = 0; i < amountRead; i++)
        {
            char c = Convert.ToChar( data[i] );
            if ( c == 'a' || c == 'A' ||
                c == 'e' || c == 'E' ||
                c == 'i' || c == 'I' ||
                c == 'o' || c == 'O' ||
                c == 'u' || c == 'U')
            {
                count++;
            }
        }
        Console.WriteLine("Number of vowels = {0}", count);
    }
}
