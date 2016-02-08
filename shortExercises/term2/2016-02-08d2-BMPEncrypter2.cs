// BMP Encripter
// Alternate version
// 08-02-2016

using System;
using System.IO;

public class BMPEncrypter
{
    public static void Main(string[] args)
    {
        string name;
        
        if (args.Length == 1)
            name = args[0];
        else
        {
            Console.Write("Enter the file name: ");
            name = Console.ReadLine();
        }
        
        if (File.Exists(name))
        {
            FileStream myFile = new FileStream(name, FileMode.Open);
            byte[] data = new byte[myFile.Length];
            myFile.Read(data, 0, data.Length);
            myFile.Close();
            
            FileStream outFile = File.Create(name + ".dam2");
            outFile.WriteByte(data[1]);
            outFile.WriteByte(data[0]);
            outFile.Write(data, 2, data.Length-2);
            outFile.Close();
        }
        else
            Console.WriteLine("File does not exist");
    }
}
