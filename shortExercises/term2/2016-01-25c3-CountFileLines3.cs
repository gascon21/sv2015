/*
* Carla Liarte Felipe
* 
*/

using System;
using System.IO;

public class CountLinesFile
{
    public static void Main()
    {
        int lines = 0;
        Console.Write("Enter file name: "); 
        string name = Console.ReadLine();
        
        using (StreamReader myFile = new StreamReader(name))
        {
            string file;
            
            do
            {
                file = myFile.ReadLine();
                if (file != null)
                    lines ++;
            }
            while (file != null);
        }
        Console.WriteLine("Amount of lines: {0}",lines);
    }
}
