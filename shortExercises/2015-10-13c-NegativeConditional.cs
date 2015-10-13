// Create a C# program to ask the user for a number "x" and assign the 
// value 1 to a variable "negative" if it is negative, or 0 otherwise. 
// Do it first using "if" and then using the conditional operator.

// 13-10-2015

using System;

public class NegativeConditional
{
    public static void Main()
    {
        int negative;
        
        Console.Write("Enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        if (x < 0)
            negative = 1;
        else
            negative = 0;
            
        negative = x < 0 ? 1 : 0;
    }
    
}
