// Ruben Blanco
// Program: BMPbinaryFiles

using System;
using System.IO;

public class BMPbinaryFiles
{
    public static void Main()
    {
        Console.Write("Enter the name of the file: ");
        string name = Console.ReadLine();
        
        if (! File.Exists(name))
        {
            Console.WriteLine("File does not exist");
        }
        else
        {
            FileStream myFile = File.OpenRead(name);
            byte data1 = (byte) myFile.ReadByte();
            byte data2 = (byte) myFile.ReadByte();
            
            // B == 66 in ascii (0x42)
            // M == 77 in ascii (0x4D)
            
            if (( data1 == 0x42) && (data2 == 0x4D))
            {
                // Skip bytes
                for (int i = 2; i < 30; i++)
                    myFile.ReadByte();
                
                // Read compression data
                byte comp1 = (byte) myFile.ReadByte();
                if(comp1 != 0)
                {
                    Console.WriteLine("File compressed");
                }
                else
                    Console.WriteLine("File not compressed");
            }
            else
                Console.WriteLine("File is not a BMP");
            myFile.Close();
        }
    }
}
