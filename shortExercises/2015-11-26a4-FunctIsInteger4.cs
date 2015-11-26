// IsInteger

using System;

public class IsInteger4
{
    public static bool IsInteger( string x )
    {
        try
        {
            int n = Convert.ToInt32( x );
        }
        catch (Exception)
        {
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
