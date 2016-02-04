// Count vowels in a binary file
// Version 1: Reading one byte a time

using System;
using System.IO;

public class VowelsBinary1
{
    public static void Main()
    {
        Console.WriteLine("Enter file name: ");
        string name = Console.ReadLine();
        
        FileStream f = new FileStream(name, FileMode.Open);
        int count = 0;

        for ( int pos = 0; pos < f.Length; pos++)
        {
            byte data = (byte) f.ReadByte();
            char c = Convert.ToChar( data );
            if ( c == 'a' || c == 'A' ||
                c == 'e' || c == 'E' ||
                c == 'i' || c == 'I' ||
                c == 'o' || c == 'O' ||
                c == 'u' || c == 'U')
            {
                count++;
            }
        }
        f.Close();
        Console.WriteLine("Number of vowels = {0}", count);
    }
}
