// Copy files using a queue
// Chen Chao
// 10-02-2016

using System;
using System.IO;
using System.Collections;

public class Queue1
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();

        if (!File.Exists(name))
        {
            Console.WriteLine("File does not exist");
            return;
        }
               
        StreamReader inFile = File.OpenText(name);
        
        string line;
        Queue myQueue = new Queue();
        
        do
        {
            line = inFile.ReadLine();
            
            if (line != null)
                myQueue.Enqueue(line);
        }
        while (line != null);
        inFile.Close();
        
        StreamWriter outFile = File.CreateText(name + ".out.txt");
        while (myQueue.Count > 0)
            outFile.WriteLine(myQueue.Dequeue());
            
        outFile.Close();
    }
}
