// Miguel Moya Ortega
// display negative number

using System;

public class Negative
{
    public static void Main()
    {
        Console.WriteLine ("Enter a number:");
        int x = Convert.ToInt32 ( Console.ReadLine () );
        Console.WriteLine ("Enter a number:");
        int y = Convert.ToInt32 ( Console.ReadLine () );
        
        if (x < 0 && y < 0)
            Console.WriteLine ("Negative numbers: {0} and {1}", y, x);
        else if ( x < 0)
            Console.WriteLine ("Negative numbers: {0}",x);
        else if ( y < 0)
            Console.WriteLine ("Negative numbers: {0}",y);
        else
            Console.WriteLine ("Negative numbers: None");
    }
}
