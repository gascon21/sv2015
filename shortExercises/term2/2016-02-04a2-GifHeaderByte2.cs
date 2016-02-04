// Reading the header of a binary GIF File

using System;
using System.IO;

public class GifChecker
{
    public static void Main()
    {
        
        byte[] data = new byte[5];

        Console.WriteLine("File name: ");
        string fileName = Console.ReadLine();
        
        FileStream myFile = new FileStream (fileName, FileMode.Open);
        for (int i = 0; i < 5; i++)
            data[i] = (byte)myFile.ReadByte();
        myFile.Close();
        
        if(data[0] == 'G' && data[1] == 'I' && data[2] == 'F' && data[3] == '8')
        {
            if (data[4] == '7')
                Console.WriteLine("GIF v87");
            else if(data[4] == '9')
                Console.WriteLine("GIF v89");
            else
                Console.WriteLine("Not a GIF");
        }
        else
            Console.WriteLine("Not a GIF");
    }
}
