// Binary Searchm, recursive version
// Chen Chao
// 12-05-2016

using System;

public class BinarySearch
{
    public static int Search(int[] n, int from, int to, int value)
    {
        int mid = from + (to - from) / 2;
        if (n[to] == value)
            return to;
        else if (n[mid] == value)
            return mid;
        else if (mid == from)
            return -1;
        else if (n[mid] > value)
            return Search(n, from, mid, value);
        else
            return Search(n, mid, to, value);
    }
    
    public static void Main()
    {
        int[] data = { 2, 4, 7, 9, 12, 15, 17, 18 };
        
        int[] searchValues = { 1, 2, 10, 12, 13, 18, 19 };
        
        foreach (int searchValue in searchValues)
            if (Search(data, 0, data.Length-1, searchValue) >= 0)
                Console.WriteLine("{0} found", searchValue);
            else
                Console.WriteLine("{0} not found", searchValue);
    }
}
