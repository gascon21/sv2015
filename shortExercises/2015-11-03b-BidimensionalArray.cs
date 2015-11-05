// Bidimensional Array

using System;

public class BidimensionalArray
{
    public static void Main()
    {
        const int BLOCKS = 2;
        const int SIZE = 5;
        double[,] data = new double[BLOCKS,SIZE];
        
        for(int block = 0; block < BLOCKS; block++)
            for(int pos = 0; pos < SIZE;pos++)
            {
                Console.Write("Enter data{0} number {1}: ",
                    block+1, pos+1);
                data[block,pos] = Convert.ToDouble(Console.ReadLine());
            }
        
        
        for(int block = 0; block < BLOCKS; block++)
            for(int pos = 0; pos < SIZE;pos++)
            {
                Console.WriteLine("Data{0} number {1} is: {2}",
                    block+1,pos+1,data[block,pos]);
            }
    }
}
