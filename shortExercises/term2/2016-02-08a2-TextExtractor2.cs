// Sacha Van de sijpe Bueno

using System;
using System.IO;

public class Example3BinaryFile
{
    public static void Main()
    {
        Console.Write("Enter a file: ");
        string file = Console.ReadLine();
        
        
        if (File.Exists(file))
        {
            FileStream myFile = File.OpenRead(file);
            int lengthFile = (int)myFile.Length;
            
            byte[] data = new byte [lengthFile];
            
            /*for (int i = 0; i < lengthFile; i++)
                data[i] = (byte) myFile.ReadByte();*/
            
            myFile.Read(data, 0, lengthFile);
                
            myFile.Close();
            
            StreamWriter myFileOut = File.CreateText(file+".txt");
            
            for (int i = 0; i < lengthFile; i++)
                if (data[i] == 10 || data[i] == 13 || data[i] >= 32 || data[i] <= 127)
                    myFileOut.Write(Convert.ToChar(data[i]));
            
            myFileOut.Close();
        }
        else
            Console.WriteLine("Invalid File");
    }
}
