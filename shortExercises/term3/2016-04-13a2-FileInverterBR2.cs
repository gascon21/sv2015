// File Inverter using BinaryReader and BinaryWriter
// Version 2: seeking from the end

using System;
using System.IO;

public class Inverter
{
    public static void Main()
    {
        Console.Write("Enter the name of the file: ");
        string name = Console.ReadLine();
        
        if (!File.Exists(name))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                BinaryReader myRead = new BinaryReader(File.Open(name, FileMode.Open));
                BinaryWriter myWrite = new BinaryWriter(File.Open(name + ".inv", FileMode.Create));
                
                for (int i = 0; i < myRead.BaseStream.Length; i++)
                {
                    myRead.BaseStream.Seek(-i - 1, SeekOrigin.End);
                    myWrite.Write(myRead.ReadByte());
                }
                
                myRead.Close();
                myWrite.Close();
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
