// IsInteger

using System;

public class IsInteger3
{
    public static bool IsInteger( string x )
    {
        foreach(char number in x)
        {
            if (number < '0') return false;
            if (number > '9') return false;
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
