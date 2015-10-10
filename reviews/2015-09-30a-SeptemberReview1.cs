/*
 * Carla Liarte Felipe
 * Product of two numbers 
*/

public class SeptemberReview1
{
    public static void Main()    
    {
        int x, y;
        int product;
        
        System.Console.Write( "Enter the first number :");
        x = System.Convert.ToInt32( System.Console.ReadLine() );
    
        System.Console.Write( "Enter the second number :");
        y = System.Convert.ToInt32( System.Console.ReadLine() );
        
        product = x * y;
        System.Console.Write( "The product is :" );
        System.Console.WriteLine (product);
                
    }
}
