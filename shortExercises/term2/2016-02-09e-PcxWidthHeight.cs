//Victor Carretero Blasco
using System;
using System.IO;

public class binaryReader
{
    public static void Main(string[] args)
    {
        string name1;
        if (args.Length >= 1)
        { 
            name1 = args[0];
        }
        else
        {
            Console.WriteLine("Enter file name: ");
            name1 = Console.ReadLine();
        }

        if (!File.Exists(name1))
            return;

        BinaryReader myFile = new BinaryReader(
			File.Open(name1,FileMode.Open));
        myFile.BaseStream.Seek(4, SeekOrigin.Begin);

        short xMin = myFile.ReadInt16();
        short yMin = myFile.ReadInt16();
        short xMax = myFile.ReadInt16();
        short yMax = myFile.ReadInt16();

        Console.WriteLine("Width = {0}, height = {1}", 
			xMax - xMin + 1, yMax - yMin + 1);
        myFile.Close();
    }
}
