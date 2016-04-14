// Chen Chao
// 13-04-2016

using System;
using System.IO;
using System.Collections.Generic;

public class FileInverter
{
    public static void Main(string[] args)
    {
        string fileName;

        if (args.Length > 0)
        {
            fileName = args[0];
        }
        else
        {
            Console.Write("Enter the file name: ");
            fileName = Console.ReadLine();
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return;
        }
        
        try
        {
            // Reading to a stack
            BinaryReader readFile = new BinaryReader(
                File.Open(fileName, FileMode.Open));
            Stack<byte> myStack = new Stack<byte>();
            for (long i = 0; i < readFile.BaseStream.Length; i++)
            {
                myStack.Push(readFile.ReadByte());
            }  
            readFile.Close();
            
            // Dumping from stack to the new file
            BinaryWriter writeFile = new BinaryWriter(
                File.Open(fileName + ".inv", FileMode.Create));
            while (myStack.Count > 0)
                writeFile.Write(myStack.Pop());
            writeFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/Output error: {0}", ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Enexpected error: {0}", ex.Message);
        }
    }
}
