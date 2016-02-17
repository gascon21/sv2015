// Width and height of a BMP file

using System;
using System.IO;

public class BMPFileStream
{
    public static void Main()
    {
        const int HEADER_SIZE = 54;
        string fileName;

        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();

        if (!File.Exists(fileName))
            Console.WriteLine("File not found!");
        {
            FileStream myFile = new FileStream (fileName, FileMode.Open);
            byte [] data = new byte [HEADER_SIZE];
            int amountRead = myFile.Read(data,0,HEADER_SIZE);
            myFile.Close();
            
            if (amountRead != HEADER_SIZE)
                Console.WriteLine("Read error!");
             
            if (data[0] == 'B' && data[1] == 'M')
            {                
                Console.WriteLine("Width: " + 
                    data[18] +
                    data[19]*256 +
                    data[20]*256*256 +
                    data[21]*256*256*256);

                Console.WriteLine("Height: " + + 
                    data[22] +
                    data[23]*256 +
                    data[24]*256*256 +
                    data[25]*256*256*256);
            }
            else
                Console.WriteLine(fileName + " is not a BMP File. ");
            myFile.Close();
        }
    }
}
