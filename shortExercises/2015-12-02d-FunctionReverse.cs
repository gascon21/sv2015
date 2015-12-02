/*
    Sacha Van de sijpe Bueno
*/

using System;

public class FunctionReverse
{
    public static string Reverse(string text)
    {
        string newText = "";
        for (int i = text.Length-1; i >= 0; i--)
            newText += text[i];
        return newText;
    }
    
    public static string ReverseR(string text)
    {
        if (text.Length <= 1)
            return text;
        
        return ReverseR(
            text.Substring(1,text.Length-1))
            + text[0];
    }
    
    public static void Main()
    {
        string x = Reverse( "Hola" );
        Console.WriteLine(x);
        Console.WriteLine ( Reverse( "Qué tal?") );
        
        string x2 = ReverseR( "Hola" );
        Console.WriteLine(x2);
        Console.WriteLine ( ReverseR( "Qué tal?") );
    }
}
