// Miguel Moya Ortega
// perimeter

using System;

public class perimeter
{
    public static void Main()
    {
        Console.Write ("Enter the width: ");
        double width = Convert.ToDouble ( Console.ReadLine () );
        Console.Write ("Enter the height: ");
        double height = Convert.ToDouble ( Console.ReadLine () );
        
        Console.WriteLine ("The perimeter is: {0}", 
			(width + height) * 2 );
			
        Console.WriteLine ("The area is: {0}", 
			width * height);
			
        Console.WriteLine ("The diagonal is: {0}",
            Math.Sqrt((width * width)+(height * height))); 
    }
}
