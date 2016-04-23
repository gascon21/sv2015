// Cipher a binary file using XOR
// (Version 2: FileStream)
// Chen Chao
// 22-04-2016

using System;
using System.IO;

public class FileCipher2
{
    public static void Main(string[] args)
    {
        // Read file name
        string fileName;
        byte n;
        if (args.Length == 2)
        {
            fileName = args[0];
            n = Convert.ToByte(args[1]);
        }
        else
        {
            Console.Write("Lost parameter");
            return;
        }

        // Check if file exists
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist");
            return;
        }

        try
        {
            // Read all the data, cipher, write data
            FileStream read = new FileStream(fileName, FileMode.Open);
            int size = (int) read.Length;
            byte[] data = new byte[size];
            read.Read(data, 0, size);
            read.Close();
            
            FileStream write = new FileStream(fileName, FileMode.Open);
            for (int i = 0; i < size; i++)
                data[i] ^= n;
            write.Write(data, 0, size);
            write.Close();
        }
        
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/Ouput error: {0}", ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
        }
    }
}
