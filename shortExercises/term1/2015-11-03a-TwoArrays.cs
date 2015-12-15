// Jorge Montalvo Blanes
// 

using System;

public class TwoArrays
{
    public static void Main()
    {
        const int SIZE = 5;
        double[] data1 = new double[SIZE];
        double[] data2 = new double[SIZE];
        
        for(int i = 0; i < SIZE;i++)
        {
            Console.Write("Enter data1 number {0}: ",i+1);
            data1[i] = Convert.ToDouble(Console.ReadLine());
        }
        for(int i = 0; i < SIZE;i++)
        {
            Console.Write("Enter data2 number {0}: ",i+1);
            data2[i] = Convert.ToDouble(Console.ReadLine());
        }
        for(int i = 0; i < SIZE;i++)
        {
            Console.WriteLine("Data1 number {0} is: {1}",i+1,data1[i]);
        }
        for(int i = 0; i < SIZE;i++)
        {
            Console.WriteLine("Data2 number {0} is: {1}",i+1,data2[i]);
        }
    }
}
