// Indra Lopez
// Program used to get the max and the min of a function

using System;
public class MAxMIn {
    
    public static void MaxMinArray(int []x, ref int max, ref int min) {
        max = x[0];
        min = x[0];
        for(int i = 0; i < x.Length;i++){
            if( x[i] > max){
                max = x[i];
            }
            if( x[i] < min){
                min = x[i];
            }
            
        }
    }
    
    public static void Main() {
        int max = 0, min = 0;
        int[] array = {10,20,-30,40,6,8,9,10,2};
        MaxMinArray(array,ref max,ref min);
        Console.WriteLine("Max is {0} and min is {1}",
            max,min);
    }
}
