// Reading the header of a binary GIF File

using System;
using System.IO;

public class GifChecker
{
    public static void Main(string[] args)
    {
        FileStream myFile = new FileStream("prueba.gif", 
            FileMode.Open);
        byte data1 = (byte)myFile.ReadByte();
        byte data2 = (byte)myFile.ReadByte();
        byte data3 = (byte)myFile.ReadByte();
        byte data4 = (byte)myFile.ReadByte();
        byte data5 = (byte)myFile.ReadByte();
        myFile.Close();

        if (data1=='G' && data2=='I' && data3=='F' && data4=='8')
        {
            if (data5=='9')
                Console.WriteLine("GIF version 89");
            else if (data5=='7')
                Console.WriteLine("GIF version 87");
            else
                Console.WriteLine("Not a valid GIF");
        }
        else
            Console.WriteLine("Not a valid GIF");
    }
}

