/*
Create a program to ask the user for the following GPS data, store them 
in a struct and then display them: latitude, longitude, speed, 
elevation, orientation (co-latitude & azimuth)
 
First approach: fixed values
*/
using System;

public class Array2D
{
    
    
    public static void Main()
    {
        double[,] data = new double[2,2] {
            { 5, 7 },
            { 5, 7 },
        };
        
        
        if ((data[0,0] == data[1,0])
                && (data[0,1] == data[1,1]))
            Console.WriteLine("Both rows are equal");
        else
            Console.WriteLine("Both rows are NOT equal");
    }
}
