/* Author: Victor Carretero Blasco
 * Sort an array and return the result in a different array
 */
using System;
public class arraysort
{
    
    public static void Main()
    {
        int[] numbers = { 1, 5, 7, 4, 6, 83, 6 };
        int[] numbersOrder = sortArray(numbers);
        for (int i=0;i<numbersOrder.Length;i++)
            Console.Write("{0} ",numbersOrder[i]);
        Console.WriteLine();
        
        int[] numbers2 = { 1, 5, 7, 4, 6, 83, 6, 23, 48, 92, 15, -6 };
        int[] numbersOrder2 = sortArray(numbers2);
        for (int i = 0; i < numbersOrder2.Length; i++)
            Console.Write("{0} ", numbersOrder2[i]);
        Console.WriteLine();
    }
    
    public static int[] sortArray(int[] numbers)
    {
        for (int i=0; i<numbers.Length-1; i++)
        {
            for (int j=i+1; j<numbers.Length; j++)
            {
                if ( numbers[i] > numbers[j] )
                {
                    int number = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = number;
                }
            }
        }
        return numbers;
    }
}
