// Replace text in a text file

using System;
using System.IO;

public class TextReplace
{
    
    public static int Main(string[] args ) 
    {
        StreamReader myFile;
        StreamWriter myNewFile;
        string line;
        
        if (args.Length != 3)
        {
            Console.WriteLine("Missing parameters: file word replaceStr");
            return 1;
        }
        
        myFile = File.OpenText (args[0]);
        myNewFile = File.CreateText(args[0]+".out");
        
        do
        {
            line = myFile.ReadLine();
            
            if (line != null)
            {
                line = line.Replace(args[1], args[2]);
                myNewFile.WriteLine(line);
            }
        }
        while (line!= null);
        
        myFile.Close();
        myNewFile.Close();
        return 0;
    }
}
