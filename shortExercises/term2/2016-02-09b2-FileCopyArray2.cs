// Binary Copier (array)

using System;
using System.IO;

public class BinaryCopierBlocks
{
    public static void Main()
    {
        Console.WriteLine("Enter the name of the file");
        string name = Console.ReadLine();
        
        FileStream myRead = File.OpenRead(name);
        int size = (int) myRead.Length;
        byte[] data = new byte[size];
        myRead.Read(data, 0, size);
        myRead.Close();
        
        FileStream myWrite = File.Create(name + ".out");
        myWrite.Write(data, 0, size);
        myWrite.Close();
    }
}
