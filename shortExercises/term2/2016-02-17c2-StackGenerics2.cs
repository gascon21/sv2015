// File inverter, with a Stack of strings using Generics
// Chen Chao
// 17-02-2016

using System;
using System.IO;
using System.Collections;

public class Stack<T>
{
    private ArrayList list = new ArrayList();
    
    public void Push(T obj)
    {
        list.Add(obj);
    }
    
    public T Pop()
    {
        T n = (T) this.Seek();
        list.RemoveAt(list.Count - 1);
        return n;
    }
    
    public T Seek()
    {
        return (T)list[list.Count - 1];
    }
    
    public int Count()
    {
        return list.Count;
    }
}


public class StackTest
{
    public static void Main()
    {
        // Let's ask the user for the file names
        Console.Write("Enter the input file name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the output file name: ");
        string name2 = Console.ReadLine();
        
        if (!File.Exists(name))
        {
            Console.WriteLine("File does not exists.");
            return;
        }
        if (File.Exists(name2))
        {
            Console.WriteLine("File already exists.");
            return;
        }
        
        // And read the source file
        StreamReader inFile = File.OpenText(name);
        Stack<string> myStack = new Stack<string>();
        string line;
        do
        {
            line = inFile.ReadLine();
            if (line != null)
                myStack.Push(line);
        }
        while (line != null);
        inFile.Close();
        
        // And dump to the destination file
        StreamWriter outFile = File.CreateText(name2);
        while (myStack.Count() > 0)
            outFile.WriteLine(myStack.Pop());
        outFile.Close();
        
        Console.WriteLine("Done");
    }
}
