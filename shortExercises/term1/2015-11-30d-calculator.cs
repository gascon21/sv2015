using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        if (args.Length != 3)
            Console.WriteLine("3 parameters expected!");
        else
        {
            switch( args[1] )
            {
                case "+":
                    Console.WriteLine( Convert.ToInt32(args[0])
                        + Convert.ToInt32(args[2]) );
                    break;
                case "-":
                    Console.WriteLine( Convert.ToInt32(args[0])
                        - Convert.ToInt32(args[2]) );
                    break;
                case "*":
                    Console.WriteLine( Convert.ToInt32(args[0])
                        * Convert.ToInt32(args[2]) );
                    break;
                case "/":
                    Console.WriteLine( Convert.ToInt32(args[0])
                        / Convert.ToInt32(args[2]) );
                    break;
            }
        }
    }
}

