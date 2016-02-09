// David Gascón López
// Copy paste blocks

using System;
using System.IO;

public class CopyPasteBlocks
{
    public static void Main()
    {
        Console.Write("Enter the filename: ");
        string fileName = Console.ReadLine();
        
        Console.Write("Enter the second filename: ");
        string fileName2 = Console.ReadLine();
        
        FileStream myFile = File.OpenRead(fileName);
        FileStream myFile2 = File.Create(fileName2);
        
        int blockSize = 100 * 1024 * 1024;
		byte[] myArray = new byte[blockSize];
        
        do
        {
            int readBytes = myFile.Read(myArray, 0, blockSize);
            myFile2.Write(myArray, 0, readBytes);
        }
		while( readBytes == blockSize);
        
        myFile.Close();
        myFile2.Close();
    }
}
