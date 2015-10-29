// David Gascón López
// Reverse array

using System;
public class ReverseArray
{
    public static void Main()
    {
        int [] data2 = new int [10];
        for(int i = 0 ; i < 10 ; i ++)
        {
            Console.WriteLine("Enter data {0}: ",i+1);
            data2[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for(int i = 9 ; i >= 0 ; i --)
            Console.Write("{0} ", data2[i]);
        Console.WriteLine();
    }
}
