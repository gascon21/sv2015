// BMP Encripter
// Chen Chao
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
            
            byte tempData = data[0];
            data[0] = data[1];
            data[1] = tempData;
            
            FileStream outFile = File.Create(name + ".dam");
            outFile.Write(data, 0, data.Length);
            outFile.Close();
        }
        else
            Console.WriteLine("File does not exist");
    }
}
