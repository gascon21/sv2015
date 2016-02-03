/*
* Carla Liarte Felipe
* 3-2-16
*/

using System;
using System.IO;

public class BinaryFiles
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();
        
        FileStream MyFile = File.OpenRead(name);
        byte data = (byte) MyFile.ReadByte();
        MyFile.Close();
        
        Console.Write("First byte is: ");
        Console.WriteLine(data);
    }
}
