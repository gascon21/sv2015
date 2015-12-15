/*
Create two functions to display the first n+1 powers of 3, ending with 
n = 0. The first function must do it in an iterative way (NOT 
recursive, but using  “for” o “while”), and must be called 
“writePowers3”. The second function must do it in a recursive way, and 
must be called “writePowers3r”. (2 points). An example of use might be:

WritePowers3( 4 );
81 27 9 3 1
WritePowers3r( 4 );
81 27 9 3 1
*/

using System;
public class Powers3
{
    public static void WritePowers3( int n )
    {
        for (int i=n; i>=0; i--)
            Console.Write( "{0} ", Power3( (uint) i) );
    }
    
    public static void WritePowers3r( int n )
    {
        // Base case
        if (n == 0)
        {
            Console.Write("1");
            return;
        }
        
        // General case
        Console.Write( "{0} ", Power3( (uint) n) );
        WritePowers3r( n-1 );
    }
    
    public static int Power3(uint exp)
    {
        int result = 1;
        for (uint i=0; i<exp; i++)
            result *= 3;
        return result;
    }
    
    public static void Main()
    {
        WritePowers3( 4 );
        Console.WriteLine();
        WritePowers3r( 4 );
        Console.WriteLine();
    } 
}
