// Binary file inverter, using FileStream

using System;
using System.IO;

public class Inverter
{
    public static void Main(string[] args)
    {
        string name;
        
        if (args.Length > 0)
            name = args[0];
        else
        {    
            Console.Write("Enter file name: ");
            name = Console.ReadLine();
        }
  
        if (! File.Exists(name))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        try
        {
            FileStream inputFile = File.OpenRead(name);
            int size = (int) inputFile.Length;
            byte[] data = new byte[size];
            int amountRead = inputFile.Read(data, 0, size);
            inputFile.Close();
            
            FileStream outputFile = File.Create(name+".inv");
            for (int i = amountRead-1; i>=0; i--)
            {
                outputFile.WriteByte(data[i]);
            }
            outputFile.Close();

        }
        catch(IOException)
        {
            Console.WriteLine("Problem while reading / writing");
        }
        catch(Exception e)
        {
            Console.WriteLine("Unexpected Error: "+ e.Message);
        }

    }
}
