// Miguel Moya Ortega

using System;
using System.IO;
using System.Collections;

public class StackAndFile
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        Stack stack = new Stack();
        
        if (File.Exists(fileName))
        {
            StreamReader file = File.OpenText(fileName);
            StreamWriter file2 = File.CreateText(fileName + ".copy");
            
            string line = "";
            do
            {
                line = file.ReadLine();
                if (line != null)
                    stack.Push(line);
            }
            while(line != null);
            
            int totalStack = stack.Count;
            for (int i = 0; i < totalStack; i++)
                file2.WriteLine((string) stack.Pop());
            
            file.Close();
            file2.Close();
            Console.WriteLine("Done!");
        }
        else
            Console.WriteLine("The file doesn't exist.");
    }
}
