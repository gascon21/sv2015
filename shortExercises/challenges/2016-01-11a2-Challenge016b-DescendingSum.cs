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
            while (n!="")
            {
                sum += Convert.ToInt64( n );
                n = n.Remove(0,1);
            }
            Console.WriteLine(sum);
            
            n = Console.ReadLine();
        }
    }
}
