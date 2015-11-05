using System;
public class TriangleOfName
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();        
        
        for (int i=0; i<name.Length; i++)
            Console.WriteLine(name.Substring(0,i+1));
    }
}
