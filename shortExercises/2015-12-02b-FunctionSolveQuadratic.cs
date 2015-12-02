/* Author: Victor Carretero Blasco
 * 
 * */
using System;
public class SolveQuadraticClass
{
    public static void Main()
    {
        double x1,x2;
        
        Console.WriteLine("Insert value of a");
        double a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Insert value of b");
        double b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Insert value of c");
        double c = Convert.ToInt32(Console.ReadLine());
        
        SolveQuadratic(a,b,c,out x1,out x2);
        
        Console.WriteLine("x1={0} x2={1}",x1,x2);
    }
    
    public static void SolveQuadratic(double a,double b,double c, 
        out double res1, out double res2)
    {
        if (a == 0)
        {
            res1 = c/-b;
            res2 = -9999;
        }
        else if (c == 0)
        {
            res1 = b/-a;
            res2 = -9999;
        }
        else
        {
            double tmp = (b*b) - (4*a*c);
            if (tmp < 0 )
            {
                res1 = -9999;
                res2 = -9999;
            }
            else
            {                
                tmp = Math.Sqrt(tmp);
                res1 = -b + tmp;
                res2 = -b - tmp;
                double dem = 2*a;
                res1 /= dem;
                res2 /= dem;
            }
        }
    }
    
}
