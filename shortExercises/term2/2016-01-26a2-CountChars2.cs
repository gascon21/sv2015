// Count chars in the lines of a text file (2)

using System;
using System.IO;

public class CharsCounter
{ 
    public static void Main() 
    { 
        string fileName;
        
        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();
        using (StreamReader file = new StreamReader (fileName))
        {
            Console.WriteLine("The file has {0} characters", 
                file.BaseStream.Length);
        }
    } 
}

