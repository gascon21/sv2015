/* Miguel Moya Ortega

Create a program to ask the user for 10 real numbers, calculate their 
average and display the ones which are over the average.
*/

using System;

public class averageOver
{
    public static void Main()
    {
        const int SIZE = 10;
        double[] data= new double[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write ("Enter the {0} number: ", i+1);
            data[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        double sum = 0;
        for (int i = 0; i < SIZE; i++)
            sum += data[i];
        double average = sum / SIZE;
        
        for (int i = 0; i < SIZE; i++)
            if (average < data[i])
                Console.Write ("{0} ", data[i]);

        Console.WriteLine ("are over.");
    }
}
