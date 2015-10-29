// Search array
// Second approach, using a counter

using System;

public class ArraysSearch
{
    public static void Main()
    {
    
        int[] data = {20, 35, 50, 17, 50, 32};
        int cont=0;
                   
        Console.Write("Enter the number to search: ");
        int number =  Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < 6; i++)
            if(data[i] == number)
                cont++;
                
        if(cont!=0)
            Console.WriteLine("Found!");
        else
            Console.WriteLine("Not found!");
            
    }
}
