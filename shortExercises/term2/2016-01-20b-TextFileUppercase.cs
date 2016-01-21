// Program: TextFile3

using System;
using System.IO;

public class TextFile4
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();
        StreamReader myFile = 
            File.OpenText(name);
        StreamWriter myFile2 = 
            File.CreateText(name+".upper");
            
        string line;
        do
        {
            line = myFile.ReadLine();
            if (line != null)
                myFile2.WriteLine(line.ToUpper());
        }
        while (line != null);
        myFile.Close();
        myFile2.Close();
    }
}
