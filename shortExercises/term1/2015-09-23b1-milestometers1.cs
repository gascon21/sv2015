/*  Maria Jesus Atalaya
    Jose Vicente Leal
    tranformar miles to meters
*/

using System;
public class MilesToMeters
{
    public static void Main()
    {
        // we declare variables
        int miles;
        int meters;
        
        // we ask the user for data
        Console.WriteLine("Enter miles:");
        miles = Convert.ToInt32(Console.ReadLine() );
         
        meters=miles*1609344/1000;
        
        Console.WriteLine("Result {0},{1} meters",meters,
            ((miles*1609344)% 1609 % 1000));
        
    }
}
