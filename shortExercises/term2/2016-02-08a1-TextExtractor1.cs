//Jorge Montalvo Blanes
using System;
using System.IO;

public class TextExtractor
{
    public static void Main()
    {
        Console.WriteLine("Enter file name: ");
        string name = Console.ReadLine();
        
        FileStream myFile = new FileStream(name, FileMode.Open);
        StreamWriter myFile2 = File.CreateText(name+".txt");

        for ( int pos = 0; pos < myFile.Length; pos++)
        {
            byte data = (byte) myFile.ReadByte();
            char c = Convert.ToChar( data );
            if ( c == 10 || c == 13 || (c >= 32 && c <= 127) )
            {
                myFile2.Write(c);
            }
        }
        myFile.Close();
        myFile2.Close();
    }
}
