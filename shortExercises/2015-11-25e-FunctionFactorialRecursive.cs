/* Factorial 
5 ! = 5 * 4 * 3 * 2 * 1
4 ! = 4 * 3 * 2 * 1
3 ! = 3 * 2 * 1

5 ! = 5 * 4 !
*/

using System;
public class RecursiveFactorial
{
    public static int Factorial (int n)
    {
        if (n == 1)
            return 1;
            
        return n * Factorial (n-1);
    }

    public static void Main()
    {
        Console.WriteLine( "5! = " + Factorial(5));
    }
}
