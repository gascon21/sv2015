// Ruben Blanco
// Program: TextFile2

using System;
using System.IO;

public class TextFile2
{
    public static void Main()
    {
        StreamReader myFile = 
            File.OpenText("example.txt");
        string l1 = myFile.ReadLine();
        string l2 = myFile.ReadLine();
        myFile.Close();
        
        Console.WriteLine(l1);
        Console.WriteLine(l2);
    }
}
