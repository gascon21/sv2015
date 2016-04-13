// Fields of a DBF file, using BinaryReader

using System;
using System.IO;

public class DbfReader
{
    public static void Main(string[] args)
    {
        const int HEADER_SIZE = 32;
        const int NAME_LENGTH = 11;
        const int SIZE_POS = 8;
            
        string fileName;
        if (args.Length != 1)
        {
            Console.Write("Enter the name of the DBF file: ");
            fileName = Console.ReadLine();
        }
        else
            fileName = args[0];

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file doesnt exists");
        }
        else
        {
            try
            {
                BinaryReader file = new BinaryReader(
                    File.Open(fileName, FileMode.Open));

                file.BaseStream.Seek(SIZE_POS, SeekOrigin.Begin);

                int headSize = file.ReadInt16();
                int amountOfRecords = headSize / HEADER_SIZE;

                file.BaseStream.Seek(HEADER_SIZE, SeekOrigin.Begin);
                for (int i = 0; i < amountOfRecords-1; i++ )
                {
                    for ( int j = 0; j < NAME_LENGTH; j++)
                    {
                        Console.Write((char)file.ReadByte());
                    }
                    Console.WriteLine();
                    file.BaseStream.Seek(HEADER_SIZE-NAME_LENGTH, 
                        SeekOrigin.Current);
                }

                file.Close();
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
