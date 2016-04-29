// LINQ Example

using System;
using System.Linq;
 
public class Usinglinq
{
    public static void Main(string[] args)
    {
        int[] datos = { 20, 5, 7, 4, -25, 18, 5, 8, 21, 2 };

        var result =
            from n in datos
            where n > 0

            select n;

        foreach (int i in result)
            Console.Write("{0} ", i);
        Console.WriteLine();
    }
}
 
