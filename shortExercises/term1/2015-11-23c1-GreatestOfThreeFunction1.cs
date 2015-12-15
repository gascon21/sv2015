// Pedro Antonio Pérez Paterna

using System;
public class greatestOfThreeFunction
{
        public static double GreatestOfThree(
            double a,double b,double c)
        {
            if((a >= b)&&(a >= c))
                return a;
            else if((b >= a)&&(b >= c))
                return b;
            else 
                return c;
        }
        
        public static void Main()
        {
            Console.WriteLine( GreatestOfThree(2.5, 10, 8) );
            Console.WriteLine( GreatestOfThree(5, 5, 3) );
        }
}
