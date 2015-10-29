// Search array
// Fourth approach, using a boolean and finishing as soon as possible

using System;

public class ArraysSearch
{
    public static void Main()
    {
    
        int[] data = {20, 35, 50, 17, 50, 32};
        bool found = false;
                   
        Console.Write("Enter the number to search: ");
        int number =  Convert.ToInt32(Console.ReadLine());
        
        int i=0;
        while ((i < 6) && !found)
        {
            if(data[i] == number)
                found = true;
            i++;
        }
                
        if(found)
            Console.WriteLine("Found!");
        else
            Console.WriteLine("Not found!");
            
    }
}
