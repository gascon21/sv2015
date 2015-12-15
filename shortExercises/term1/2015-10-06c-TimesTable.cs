// David Gascón López
// Multiplication table

using System;
public class MultipicatioTable
{
    public static void Main()
    {
        int number;
    
        Console.Write("Enter the number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i <= 10; i++)
            Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
    }
}
