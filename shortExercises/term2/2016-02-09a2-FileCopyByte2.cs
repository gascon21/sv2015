// Binary Copier (bytes)

using System;
using System.IO;

public class BinaryCopier
{
    public static int Main(string[] args)
    {
        string inputName, outputName;
        if (args.Length == 2)
        {
            inputName = args[0];
            outputName = args[1];
        }
        else
        {
            Console.WriteLine("Enter the name of the file");
            inputName = Console.ReadLine();
            outputName = inputName + ".out";
        }
        
        if ( ! File.Exists( inputName ) )
        {
            Console.WriteLine("Input file not found!");
            return 1;
        }
        
        
        if ( File.Exists( outputName ) )
        {
            Console.WriteLine("Output file already exists!");
            return 2;
        }

        
        try
        {
            FileStream myRead = File.OpenRead(inputName);
            FileStream myWrite = File.Create(outputName);
            
            for (int i = 0; i < myRead.Length; i++)
            {
                myWrite.WriteByte( (byte)myRead.ReadByte() );
            }
            
            myRead.Close();
            myWrite.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Unexpected error! (Disc full?)" );
            return 3;
        }
        return 0;
    }
}
