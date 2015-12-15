// Indra Lopez
// Program used to get the max and the min of a function

using System;
public class MAxMIn {
    
    public static void MaxMinArray(int []x, 
        out int max, out int min) 
    {
        max = x[0];
        min = x[0];
        
        foreach (int n in x)
        {
            max = n > max ? n : max;
            min = n < min ? n : min;
        }
    }
    
    public static void Main() {
        int max, min;
        int[] array = {10,20,-30,40,6,8,9,10,2};
        MaxMinArray(array,out max,out min);
        Console.WriteLine("Max is {0} and min is {1}",
            max,min);
    }
}
