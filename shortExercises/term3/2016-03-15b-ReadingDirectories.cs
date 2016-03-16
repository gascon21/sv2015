// Ruben Blanco
// Program: ReadingDirectories

using System;
using System.IO;

public class ReadingDirectories
{
    public static void Main()
    {
        // if we want to read absolute route --- string dir = @"C:\";
        // @ used to write \ instead of \\
        
        string dir = ".";
        string [] fileList = Directory.GetFiles(dir);
            foreach(string fileName in fileList)
                Console.WriteLine(fileName);
    }
}
