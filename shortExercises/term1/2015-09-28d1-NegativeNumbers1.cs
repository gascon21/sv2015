// Vicente Cuenca Reyes
// Enter two numbers, answer how many are negative.

using System;

public class Negativenumber
{
    public static void Main()
    {
        int x,y;
        int amountOfNegatives;
        Console.WriteLine("Enter the number");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the number");
        y = Convert.ToInt32(Console.ReadLine());
        
        amountOfNegatives = 0;
        
        if (x<0) 
            amountOfNegatives = amountOfNegatives+1;
        
        if(y<0)
            amountOfNegatives = amountOfNegatives+1;
        
        Console.WriteLine("There are {0} negative numbers.",z);
        
    }
    
}
