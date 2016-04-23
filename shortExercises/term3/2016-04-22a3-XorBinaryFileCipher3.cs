// Cipher a binary file using XOR
// (Version 3: FileStream, read and write at the same time)
// Chen Chao
// 22-04-2016

using System;
using System.IO;

public class FileCipher3
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
            FileStream file = File.Open(fileName, 
                FileMode.Open, FileAccess.ReadWrite);
            int size = (int) file.Length;
            byte[] data = new byte[size];
            file.Read(data, 0, size);
            
            for (int i = 0; i < size; i++)
                data[i] ^= n;  // XOR cipher
            file.Seek(0, SeekOrigin.Begin);
            file.Write(data, 0, size);
            file.Close();
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
