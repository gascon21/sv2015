/*
Create a C# program to ask the user for three letters and display them 
in reverse order, with double quotes. For example, if the user enters 
E, N, O, your program should display "ONE" (including the double 
quotes).
*/

using System;

public class ThreeChars
{
    public static void Main()
    {
        Console.Write("Enter a letter: ");
        char c1 = Convert.ToChar( Console.ReadLine() );
        Console.Write("Enter the second letter: ");
        char c2 = Convert.ToChar( Console.ReadLine() );
        Console.Write("Enter the third letter: ");
        char c3 = Convert.ToChar( Console.ReadLine() );
        
        
        Console.WriteLine("\"{0}{1}{2}\"", c3, c2, c1);
    }
}
