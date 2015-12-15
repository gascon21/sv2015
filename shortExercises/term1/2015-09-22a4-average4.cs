/*Author: Manuel Coronado Cuevas
 *Program: Average
 *Date:22/09/2015
 * */

using System;
public class Average
{
    public static void Main()
    {
        int sum = 0;
        
        Console.WriteLine("Enter the 1st number");
        sum = sum + Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2st number");
        sum = sum + Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 3st number");
        sum = sum + Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 4st number");
        sum = sum + Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The average is {0}", 
            sum / 4 );
    }
}
