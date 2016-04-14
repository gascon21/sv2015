// File Inverter using BinaryReader and BinaryWriter
// Version 4: using... base.Read!!!

using System;
using System.IO;

public class FileInverterBR
{
    public static void Main()
    {
        string fileName;
        
        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();
        
        if (!File.Exists(fileName))
            Console.WriteLine("File doesn't exists");
        else
        {
            try
            {
                BinaryReader file = new BinaryReader(File.Open(fileName, 
                    FileMode.Open));
                int size = (int) file.BaseStream.Length;
                byte[] data = new byte[size];
                file.BaseStream.Read(data, 0, size);
                file.Close();
                
                BinaryWriter inv = new BinaryWriter(File.Open(fileName + ".inv", 
                    FileMode.Create));
                for (int i = size - 1; i > 0; i--)
                    inv.BaseStream.WriteByte(data[i]);
                inv.Close();
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
        
