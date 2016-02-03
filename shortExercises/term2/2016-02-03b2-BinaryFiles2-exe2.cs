// David Gascón López
// Read 2 byte

using System;
using System.IO;

public class BinaryFiles
{
    public static void Main()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        
        FileStream myFile = new FileStream(filename, FileMode.Open);
        byte data1 = (byte) myFile.ReadByte();
        byte data2 = (byte) myFile.ReadByte();
        myFile.Close();
        
        Console.Write(Convert.ToChar(data1));
        Console.WriteLine(Convert.ToChar(data2));
        
        if ((data1 == 0x4D) && (data2 == 0x5A))
            Console.WriteLine("It seems a valid EXE file");
        else
            Console.WriteLine("It does NOT seem a valid EXE file");
    }
}
