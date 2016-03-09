using System;
using System.IO;

public class BMPBinaryReader
{
    public static void Main(string[] args)
    {
        string fileName;
        int width, height;

        Console.Write("Enter the file name: ");
        fileName = Console.ReadLine();
        Console.WriteLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Not found ");
            return;
        } 

        BinaryReader file = new BinaryReader(
            File.Open(fileName, FileMode.Open));
        
        file.BaseStream.Seek(18, SeekOrigin.Begin);
        width = file.ReadInt32();                
        Console.WriteLine("Width: " + width);

        height = file.ReadInt32();
        Console.WriteLine("Height: " + height);
        
        file.Close();
    }
}
