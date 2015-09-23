/*Author: Manuel Coronado Cuevas
 *Program: Average
 *Date:22/09/2015
 * */

using System;
public class Average
{
    public static void Main()
    {
        int n1, n2, n3, n4;
        int sum;
        
        Console.WriteLine("Enter the 1st number");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2st number");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 3st number");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 4st number");
        n4 = Convert.ToInt32(Console.ReadLine());
        
        sum = n1 + n2 + n3 + n4; 
        Console.WriteLine("The average is {0}", 
            sum / 4 );
    }
}
