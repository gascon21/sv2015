/*  Name: Jose Vicente
    Program: digits
 *  19/10/2015
*/
using System;
public class digits
{
    public static void Main()
    {
        int count=0;
        
        Console.Write("Number?");
        int n = Convert.ToInt32(Console.ReadLine()); 
        
        if ( n < 0 )
        {
            Console.WriteLine("Warning: It is a negative number");
            n = -1*n;
        }
        
        if ( n == 0)
            Console.WriteLine("1 Digits" );
        else
        { 
            while (n > 0)
            {
                count++;
                n = n /10;               
            }
            Console.WriteLine("{0} Digits", count);
        }
        
    }    
}
