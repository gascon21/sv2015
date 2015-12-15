// Both Even?
 
using System;
public class BothEven
{
    public static void Main()
    {
        int x = 6, y = 5;
            
        bool bothEven = ((x%2==0) && (y%2==0)) ? true : false;
        
        // Also:
        // bool bothEven = ((x%2==0) && (y%2==0));
            
        Console.WriteLine(bothEven);
    }
}
