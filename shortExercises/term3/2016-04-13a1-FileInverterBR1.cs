// File Inverter using BinaryReader and BinaryWriter
// Version 1: using an array

using System.IO;
using System.Collections;
using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName;
        if (args.Length == 1)
        {
            fileName = args[0];
        }
        else
        {
            Console.Write("File name: ");
            fileName = Console.ReadLine();
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file doesn't exist");
        }
        else
        {
            try
            {
                BinaryReader file = new BinaryReader(
                    File.Open(fileName, FileMode.Open));
                BinaryWriter output = new BinaryWriter(
                    File.Open(fileName + ".inv", FileMode.Create));

                long size = file.BaseStream.Length;
                Byte[] data = new byte[size];

                for (long i = 0; i < size; i++)
                {
                    data[i] = file.ReadByte();
                }

                for (long i = size - 1; i >= 0; i--)
                {
                    output.Write(data[i]);
                }
                file.Close();
                output.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/output error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: {0}", ex.Message);
            }
        }
    }
}
