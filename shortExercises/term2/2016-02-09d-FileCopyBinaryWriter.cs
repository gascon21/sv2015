// Chen Chao
// 09-02-2016

using System;
using System.IO;

public class BinaryCopier
{
    public static void Main()
    {
        Console.Write("Enter the name of the file: ");
        string name = Console.ReadLine();
        
        if (File.Exists(name))
        {
            BinaryReader myRead = new BinaryReader(
                File.Open(name, FileMode.Open));
            BinaryWriter myWrite = new BinaryWriter(
                File.Open(name + ".txt", FileMode.Create));
            byte data;
            
            for (int i = 0; i < myRead.BaseStream.Length; i++)
            {
                data = myRead.ReadByte();
                myWrite.Write(data);
            }
            
            myRead.Close();
            myWrite.Close();
        }
    }
}
