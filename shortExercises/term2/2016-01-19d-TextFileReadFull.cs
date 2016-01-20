// Program: TextFile3

using System;
using System.IO;

public class TextFile3
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();
        StreamReader myFile = 
            File.OpenText(name);
            
        string line;
        do
        {
            line = myFile.ReadLine();
            if (line != null)
                Console.WriteLine(line);
        }
        while (line != null);
        myFile.Close();
    }
}
