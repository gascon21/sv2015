// Ruben Blanco
// Program: December 28th

using System;

public class December28
{
    public static void WriteRectangle(string name)
    {
        string spaces ="";
        for (int i = 0; i < name.Length; i++)
        {
            spaces += " ";
        }

        Console.Write(name);
        Console.Write(name);
        Console.Write(name);
        Console.WriteLine(name);
        Console.Write(name);
        Console.Write(spaces);
        Console.Write(spaces);
        Console.WriteLine(name);
        Console.Write(name);
        Console.Write(spaces);
        Console.Write(spaces);
        Console.WriteLine(name);
        Console.Write(name);
        Console.Write(name);
        Console.Write(name);
        Console.WriteLine(name);
    }
    
    public static void Main()
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        WriteRectangle(name);
    }
}
