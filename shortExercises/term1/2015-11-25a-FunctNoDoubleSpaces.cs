// Miguel Moya Ortega

/*
Create a function "NoDoubleSpaces" to receive a string as a parameter 
and return it with no double spaces.
*/

using System;

public class NoDoubleSpace
{
    public static string NoDoubleSpaces( string x )
    {
        while (x.Contains("  "))
            x = x.Replace("  "," ");
        return x;
    }
    
    public static void Main()
    {
        Console.WriteLine(NoDoubleSpaces("Ho     la"));
    }
}
