// File Splitter
using System;
using System.IO;

class FileSpliter
{
    static int Main(string[] args)
    {
        FileStream myFileStream;
        string fileName="";
        int blockSize=0;
        int blockNumber = 1;
        if (args.Length!= 2)
        {
            Console.WriteLine("Usage: split fileName sizeInBytes");
            return 1;
        }
        else
        {
            fileName = args[0];
            blockSize = Convert.ToInt32(args[1]);
        }

        myFileStream = new FileStream(fileName, FileMode.Open);
        byte[] data = new byte[blockSize];
        int bytesRead = 0;
        do
        {
            bytesRead = myFileStream.Read(data, 0, blockSize);
            
            if (bytesRead != 0)
            {
                string strCounter = blockNumber.ToString("000");
                FileStream outFile = new FileStream(
                    fileName+"."+strCounter, FileMode.Create);
                outFile.Write(data, 0, bytesRead);
                outFile.Close();
            }

            blockNumber++;
        }
        while(bytesRead == blockSize);
        myFileStream.Close();
        
        return 0;
    }
}
