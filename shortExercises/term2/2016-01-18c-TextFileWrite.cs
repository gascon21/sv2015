// Ruben Blanco
// Program: TextFile

using System;
using System.IO;

public class TextFile
{
    public static void Main()
    {
        StreamWriter myFile = 
            File.CreateText("example.txt");
        myFile.WriteLine("Hello");
        myFile.WriteLine("Bye!");
        myFile.Close();
    }
}
