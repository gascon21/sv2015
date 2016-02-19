// Hex file dumper

using System;
using System.IO;

public class HexDump
{
    public static void Main(string[] args)
    {
        string fileName;
        if (args.Length > 0)
            fileName = args[0];
        else
        {
            Console.Write("Enter the filename: ");
            fileName = Console.ReadLine();
        }
        
        if (! File.Exists( fileName ))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            FileStream file = File.OpenRead(fileName);
            int blockSize = 16;
            byte[] data = new byte[blockSize];
            
            int readBytes;
            int address = 0;
            do
            {
                Console.Write(address.ToString("x8")+ "   ");
                
                readBytes = file.Read(data, 0, blockSize);
                for(int i = 0 ; i < readBytes ; i++)
                {
                    Console.Write(data[i].ToString("x2")+ " ");
                }
                for(int i = readBytes ; i < blockSize ; i++)
                {
                    Console.Write("   ");
                }
                for(int i = 0 ; i < readBytes ; i++)
                {
                    if ((data[i] >= 32) && (data[i] <= 127))
                        Console.Write((char) data[i]);
                    else
                        Console.Write('.');
                }
                Console.WriteLine();
                address += 16;
            }
            while (readBytes == blockSize);
            
            file.Close();
        }
    }
}
