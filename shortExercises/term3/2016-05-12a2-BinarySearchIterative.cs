// Binary Searchm, iterative version
// Pedro Antonio Pérez Paterna
// 12-05-2016

using System;

public class BinSearch
{
    public static void Main()
    {
        int[] data = { 2, 4, 7, 9, 12, 15, 17, 18 };

        int[] searchValues = { 1, 2, 10, 12, 13, 18, 19 };

        foreach (int searchValue in searchValues)
            if (Search(data, 0, data.Length - 1, searchValue) >= 0)
                Console.WriteLine("{0} found", searchValue);
            else
                Console.WriteLine("{0} not found", searchValue);
    }

    public static int Search(int[] array, int from, int to, int value)
    {
        int low = from;
        int max = to;
        int mid;

        while (low <= max)
        {
            mid = (max + low) / 2;
            if (array[mid] == value)
                return mid;
            if (array[mid] < value)
                low = mid + 1;
            else if (array[mid] > value)
                max = mid - 1;
        }
        return -1;
    }

}
