/* Author: Victor Carretero Blasco
 * Sort an array passed as parameter
 * Display that array in "Main"... the array has changed!
 */
using System;
public class arraysort
{
    public static void Main()
    {
        int[] numbers = { 1, 5, 7, 4, 6, 83, 6 };
        sortArray(numbers);
        for (int i=0;i<numbers.Length;i++) 
            Console.Write("{0} ",numbers[i]);
        Console.WriteLine();
        
        int[] numbers2 = { 1, 5, 7, 4, 6, 83, 6, 23, 48, 92, 15, -6 };
        sortArray(numbers2);
        for (int i = 0; i < numbers2.Length; i++)
            Console.Write("{0} ", numbers2[i]);
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
