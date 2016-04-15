// Encrypt an BMP,
// changing the first two bytes

using System;
using System.IO;

public class EncryptBMP
{
    public static void Main()
    {
        Console.Write("File name: ");
        string fileName = Console.ReadLine();

        FileStream file = File.Open(fileName, 
            FileMode.Open, FileAccess.ReadWrite);

        byte b1 = (byte)file.ReadByte();
        byte b2 = (byte)file.ReadByte();
        if ((b1 == 'B' && b2 == 'M')
            || (b1 == 'M' && b2 == 'B'))
        {
            file.Seek(0, SeekOrigin.Begin);
            file.WriteByte(b2);
            file.WriteByte(b1);
        }
        else
        {
            Console.WriteLine("Not a bmp");
        }
        file.Close();
    }
}
