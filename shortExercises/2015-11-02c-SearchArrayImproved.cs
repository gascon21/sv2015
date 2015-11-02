// Ruben Blanco
// Program: SearchArrayImproved

using System;

public class SearchArrayImproved
{
    public static void Main()
    {
        const int SIZE = 10;
        int [] data= new int [SIZE];
        string search;
        for(int i=0;i<SIZE;i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine()); 
        }
        
        do
        {
            bool found = false;
            Console.Write("Enter the number to find: ");
            search = Console.ReadLine();
            
            if(search != "end")
            {
                int number = Convert.ToInt32(search);
                for(int i=0;i<SIZE;i++)
                {
                    if (number == data[i])
                        found = true;
                }
            }
            
            if (found)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not found");
        }
        while(search!= "end");
        Console.WriteLine("Bye!");
    }
}
    
