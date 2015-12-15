/*  Name: Jose Vicente
    Program: multiplecounter
 *  15/10/2015
*/
using System;
public class multiplecounter
{
    public static void Main()
    {
        int n = 5;
        while ( n <= 50)
        {
            Console.Write("{0} ",n);  
            n += 5;
        }
        Console.WriteLine();  
        
        n = 5;
        do
        {
            Console.Write("{0} ",n);  
            n += 5;
        }         
        while ( n <= 50);
        Console.WriteLine(); 
        
        for ( n = 5; n<= 50; n+=5)
            Console.Write("{0} ",n); 
        Console.WriteLine(); 
    }
}
