/*
Create a program to ask the user for the following GPS data, store them 
in a struct and then display them: latitude, longitude, speed, 
elevation, orientation (co-latitude & azimuth)
*/
using System;

public class Array2D
{
    
    
    public static void Main()
    {
        double[,] data = new double[2,2];
        
        for (int row=0; row<2; row++)
            for (int col=0; col<2; col++)
            {
                Console.WriteLine("Enter data for row {0}, column {1}",
                    row+1, col+1);
                data[row,col] = Convert.ToDouble( Console.ReadLine() );
            }
        
        
        if ((data[0,0] == data[1,0])
                && (data[0,1] == data[1,1]))
            Console.WriteLine("Both rows are equal");
        else
            Console.WriteLine("Both rows are NOT equal");
    }
}
