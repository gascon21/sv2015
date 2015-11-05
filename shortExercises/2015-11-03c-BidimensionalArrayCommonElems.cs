// Bidimensional Array, common elements

using System;

public class BidimensionalArrayCommonElems
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
        
        
        for(int pos1 = 0; pos1 < SIZE; pos1++)
            for(int pos2 = 0; pos2 < SIZE; pos2++)
            {
                if (data[0, pos1] == data[1, pos2])
                    Console.WriteLine(data[0,pos1]);
            }
    }
}
