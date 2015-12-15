// IsInteger

using System;

public class IsInteger1
{
    public static bool IsInteger( string x )
    {
        for(int i=0; i<x.Length; i++)
        {
            if ((x[i] != '0')
                    && (x[i] != '1')
                    && (x[i] != '2')
                    && (x[i] != '3')
                    && (x[i] != '4')
                    && (x[i] != '5')
                    && (x[i] != '6')
                    && (x[i] != '7')
                    && (x[i] != '8')
                    && (x[i] != '9'))
                return false;
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
