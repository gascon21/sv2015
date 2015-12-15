// Create a C# program to ask the user for a number "x" and assign the 
// value 1 to a variable "negative" if it is negative, or 0 otherwise. 
// Do it first using "if" and then using the conditional operator.

// 13-10-2015

using System;

public class NegativeConditional
{
    public static void Main()
    {
        int negatives;
        
        Console.Write("Enter a number: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another nunmber: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        
        if ((x1 < 0) && (x2 < 0))
            negatives = 2;
        else if ((x1 < 0) || (x2 < 0))
            negatives = 1;
        else
            negatives = 0;
            
        negatives = (x1 < 0) && (x2 < 0) ? 2 :
            (x1 < 0) || (x2 < 0) ? 1 : 0;        
    }
    
}
