// David Gascón López
// Main for the previous functions

using System;
public class MainExam2013
{
    
    public static bool IsHarshadNumber(int n)
    {
        string number = Convert.ToString(n);
        
        int sum = 0;
        
        foreach (char num in number)
        {
            sum += num - 48;
        }
        if (n % sum == 0)
            return true;
        else
            return false;
    }
    
    
    public static void SolveQuadratic(double a, double b, double c,
            ref double x1, ref double x2)
    {
        if (a == 0)
            Console.WriteLine("X is: {0}", -c / b);
        else
        {
            double discriminante = ((b * b) - (4 * a * c));
            
            if (discriminante > 0)
            {
                x1 = (-(b) + Math.Sqrt(discriminante) / (2 * a));
                x2 = (-(b) - Math.Sqrt(discriminante) / (2 * a));
            }
            else if (discriminante == 0)
            {
                x1 = (-b / (2 * a));
                x2 = -9999;
            }
                
            else
            {
                x1 = -9999;
                x2 = -9999;
            }
        }
    }
    
    
    public static void DrawParallelogram(int cols, int rows, char character)
    {
        int spaces = 0;
        
        for(int row = 0; row < rows; row ++)
        {
            for(int column = 0; column < spaces; column ++)
                Console.Write(" ");
                
            spaces ++;
            
            for(int column = 0; column < cols; column ++)
                Console.Write(character);

            Console.WriteLine();
        }
    }
    
    
    public static string Reverse(string text)
    {
        string textReverse = "";

        for (int i = text.Length - 1 ; i >= 0 ; i --)
            textReverse += text[i];
        return textReverse;
    }
    
    
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: harshad / quadratic /"
                    + " para /  reverse.");
            return 1;
        }
        else
        {
            switch(args[0])
            {
                case "harshad":
                    if (args.Length == 2)
                    {
                        if (IsHarshadNumber (Convert.ToInt32(args[1])))
                            Console.WriteLine("{0} is a Harshad number",
                                    args[1]);
                        else
                            Console.WriteLine("{0} is not a Harshad number",
                                    args[1]);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                    
                case "quadratic":
                    if (args.Length == 4)
                    {
                        double a = Convert.ToDouble(args[1]);
                        double b = Convert.ToDouble(args[2]);
                        double c = Convert.ToDouble(args[3]); 
                        
                        double x1 = 0;
                        double x2 = 0;
                        
                        SolveQuadratic (a, b, c, ref x1, ref x2);
                        Console.WriteLine("Solutions are "+x1+" and "+x2);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                    
                case "para":
                    if (args.Length == 4)
                    {
                        DrawParallelogram(Convert.ToInt32(args[1]),
                                Convert.ToInt32(args[2]),
                                Convert.ToChar(args[3]));
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

                case "reverse":
                    if (args.Length == 2)
                    {
                        string x = Reverse( args[1] );
                        Console.WriteLine(x);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;

            }
            return 0;
        }
    }
}
