//Adrian Navarro Garcia.
//

using System;
public class arrays06
{
    public static void Main()
    {
        ushort [] heights ={169,201,188,182,171};
        string [] names = {"Leonis","Rubén","David","Victor","Maria Jesus"};
        
        int posMax = 0; 

        for (int  i = 1;  i < heights.Length ; i++)
        {
            if (heights[i] > heights[posMax])
            {
                posMax = i;
            }  
        }    
        Console.Write("The tallest person is {0}",names[posMax]);
    }
}
