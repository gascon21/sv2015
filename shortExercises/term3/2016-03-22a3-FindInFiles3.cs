// David Gascón López
// Search file in the directory

using System;
using System.IO;

public class SearchFileInDirectory
{
    public static void Main()
    {
        Console.WriteLine("Enter the pattern:");
        string pattern = Console.ReadLine();
        
        Console.WriteLine("Enter the word of search");
        string wordSearch = Console.ReadLine();
        
        bool thereIs = false;
        
        string dir = ".";
        string [] fileList = Directory.GetFiles(dir, pattern);
        foreach(string fileName in fileList)
        {
            using (StreamReader myFile = File.OpenText(fileName))
            {
                string line;
                do
                {
                    line = myFile.ReadLine();
                    if(line != null)
                    {
                        if(line.Contains(wordSearch))
                            thereIs = true;
                    }
                }
                while(( ! thereIs ) && (line != null));
                
                if(thereIs)
                    Console.WriteLine(fileName);
            }
        }
    }
}
