// Width and height of a BMP file

using System;
using System.IO;

public class BMPBinaryReader
{
    public static void Main(string[] args)
    {
        string fileName;
        int width, height;

        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();

        if (!File.Exists(fileName))
            Console.WriteLine("File not found!");
        {
            BinaryReader file = new BinaryReader(File.Open(fileName, FileMode.Open));
            
            byte mark1 = file.ReadByte();
            byte mark2 = file.ReadByte();
             
            if (mark1 == 'B' && mark2 == 'M')
            {
                file.BaseStream.Seek(18, SeekOrigin.Begin);
                width = file.ReadInt32();                
                Console.WriteLine("Width: " + width);

                height = file.ReadInt32();
                Console.WriteLine("Height: " + height);
                
                file.Close();
            }
            else
                Console.WriteLine(fileName + " is not a BMP File. "); 
        }
    }
}
