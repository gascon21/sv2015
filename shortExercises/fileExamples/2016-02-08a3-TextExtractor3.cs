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
        FileStream myFile2 = File.Create(name+".txt");

        for ( int pos = 0; pos < myFile.Length; pos++)
        {
            byte data = (byte) myFile.ReadByte();
            if ( data == 10 || data == 13 || (data >= 32 && data <= 127) )
                myFile2.WriteByte(data);
        }
        myFile.Close();
        myFile2.Close();
    }
}
