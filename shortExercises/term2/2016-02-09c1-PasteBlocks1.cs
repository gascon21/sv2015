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
        int numBlocks = (int) myFile.Length / blockSize;
        if (myFile.Length % blockSize != 0)
            numBlocks++;
        
        byte[] myArray = new byte[blockSize];
        
        for(int i = 0 ; i < numBlocks ; i++)
        {
            int readBytes = myFile.Read(myArray, 0, blockSize);
            myFile2.Write(myArray, 0, readBytes);
        }
        
        myFile.Close();
        myFile2.Close();
    }
}
