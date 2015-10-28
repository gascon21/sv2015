/*
Create a program to calculate an approximation for PI using the 
expression

pi/4 = 1/1 - 1/3 + 1/5 -1/7 + 1/9 - 1/11 + 1/13 ...

The user will indicate how many terms must be used, and the program 
will display all the results until that amount of terms.
*/

using System;
public class Numbers
{
    public static void Main()
    {
        long terms = 0;
        do
        {
            Console.Write("How many terms? ");
            terms = Convert.ToInt64( Console.ReadLine() );
            if (terms != 0)
            {
                double result = 0;
                sbyte sign = 1;
                double denominator = 1;
                
                for (long step = 1; step <= terms; step++)
                {
                    double term = sign * 1.0 / denominator;
                    result += term;
                    
                    sign = (sbyte) -sign;
                    denominator += 2;
                }
                
                double pi = result * 4;  // Because PI / 4 = ...
                Console.WriteLine("PI approx  = {0}", pi);
            }
        }
        while (terms != 0);
    }
}


