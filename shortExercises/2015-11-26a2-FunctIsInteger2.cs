// IsInteger

using System;

public class IsInteger2
{
    public static bool IsInteger( string x )
    {
        for(int i=0; i<x.Length; i++)
        {
            if (x[i] < '0') return false;
            if (x[i] > '9') return false;
        }
        return true;
    }
    
    public static void Main()
    {
        Console.WriteLine(IsInteger("1234"));
        Console.WriteLine(IsInteger("12,3"));
        Console.WriteLine(IsInteger("a12"));
        Console.WriteLine(IsInteger("1234a"));
        Console.WriteLine(IsInteger("hola"));
    }
}
