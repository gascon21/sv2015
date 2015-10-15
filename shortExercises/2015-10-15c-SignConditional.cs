/*
Create a program which assigns an integer variable named "sign" the 
value "-1" or "1", depending on if an integer number n (entered by the 
user) is negative or not.

Do it in two different ways: first using "if" and then using the 
"conditional operator" (?)
*/

using System;

public class Sign
{
    public static void Main()
    {
        int sign;
        
        Console.Write("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if ( n < 0 )
            sign = -1;
        else
            sign = 1;
            
        // Alternate way
        
        sign = n < 0 ? -1 : 1 ;
        
        // In a WriteLine:
        
        Console.Write("Watch this! {0}",
            n < 0 ? -1 : 1 );
        
    }
}
