// Count chars in the lines of a text file

using System;
using System.IO;

public class CharsCounter
{ 
    public static void Main() 
    { 
        string line, fileName;
        int counter = 0;
        
        Console.Write("Enter file name: ");
        fileName = Console.ReadLine();
        using (StreamReader file = new StreamReader (fileName))
        {
            do 
            { 
                line = file.ReadLine(); 
                if (line != null)
                {
                    counter += line.Length;
                }
            } 
            while (line != null);
        }
        Console.WriteLine("The file has {0} characters", counter);
    } 
}

