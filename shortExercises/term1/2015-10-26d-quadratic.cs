using System;

public class Quadratic
{
    public static void Main()
    {
        double a,b,c;
        
        Console.Write("Enter value of a: ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value of b: ");
        b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value of c: ");
        c = Convert.ToDouble(Console.ReadLine());
        
        if (a == 0)   // Linear equation
        {
            Console.WriteLine("The only solution is {0}",
                -c/b);
        }
        else
        {
            double discriminante = (b*b)-4*a*c;
            if (discriminante > 0)   // Two solutions
            {
                double num1 = -b + Math.Sqrt(discriminante);
                double num2 = -b - Math.Sqrt(discriminante);
                double dem = 2*a;
              
                Console.WriteLine("Solutions are {0} and {1}",
                    num1/dem,num2/dem);
              }
              else if (discriminante == 0)  // One solution
              {
                double num1 = -b;
                double dem = 2*a;
              
                Console.WriteLine("Only solution is {0}",num1/dem);
              } 
              else  // No solution
              {
                Console.WriteLine("No solution");
              }
      
        } 
        
    }
}
