// Miguel Moya Ortega
using System;
using System.IO;
using System.Collections.Generic;

public class FindInFiles
{
    public static void Main()
    {
        List<string> list = new List<string>();
        Console.WriteLine("Enter the file extension: ");
        string fileExtension = Console.ReadLine();
        Console.WriteLine("Enter the sentence to find: ");
        string sentence = Console.ReadLine();
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo[] fileList = dir.GetFiles(fileExtension);
        foreach(FileInfo file in fileList)
            list.Add(file.Name);

        list.Sort();   
        bool found;         
        foreach(string fileName in list)
        {
            StreamReader file = new StreamReader(fileName);
            found = false;
            string line;
            do
            {
                line = file.ReadLine();
                if (line != null)
                    if (line.Contains(sentence))
                        found = true;
            }
            while (line != null && !found);
            file.Close();
            if(found)
                Console.WriteLine(fileName);
        }
    }
}
