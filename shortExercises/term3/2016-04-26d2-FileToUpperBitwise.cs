// File to lower, using bitwise or

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
            
            FileStream outputFile = File.Create(name+".upper");
            for (int i = 0; i<amountRead; i++)
            {
                if ((data[i] >= 'a') && (data[i] <= 'z'))
                    data[i] &= 223;
            }
            outputFile.Write(data, 0, amountRead);
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
