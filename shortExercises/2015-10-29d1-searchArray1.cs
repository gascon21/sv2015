// Search array
// First approach (incorrect)

using System;

public class ArraysSearch
{
    public static void Main()
    {
    
        int[] data = {20, 35, 50, 17, 50, 32};
                   
        Console.Write("Enter the number to search: ");
        int number =  Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < 6; i++)
            if(data[i] == number)
                Console.WriteLine("Found!");
            else
                Console.WriteLine("Not found!");
    }
}
