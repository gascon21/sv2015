// Descending sum
// 123 -> 123 + 23 + 3 = 149

using System;

public class Challenge016
{
    public static void Main()
    {
        string n = Console.ReadLine();
        while (n != "0")
        {
            long sum = 0;
            for(int i=0; i<n.Length; i++)
                sum += Convert.ToInt64( n.Substring(i) );
            Console.WriteLine(sum);
            
            n = Console.ReadLine();
        }
    }
}
