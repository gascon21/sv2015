// Sergio Martínez Mira


using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

public class Search
{
    public static void Main()
    {
        string dir = ".";
        string [] fileList = Directory.GetFiles(dir);
        List<string> filesList = new List<string>();
        
        Console.WriteLine("Enter the extension with a dot (.)");
        string extension = Console.ReadLine();
        
        Console.WriteLine("Enter the content to search");
        string content = Console.ReadLine();
        
        foreach(string fileName in fileList)
        {
            if(fileName.Contains(extension))
                filesList.Add(fileName);        
        }
        
        foreach(string fileName in filesList)
        {
            StreamReader reader = new StreamReader(fileName);
            string line;
            bool found = false;
            do
            {
                line = reader.ReadLine();
                if(line != null && line.Contains(content))
                    found = true;
            }
            while((!found) && (line != null));
            reader.Close();
            
            if(found == true)
                Console.WriteLine(fileName);
        }
    }
}
