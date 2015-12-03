// David Gascón López
// Main for the previous functions 2014

using System;
public class MainExam2014
{
    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
            if (num % i == 0) 
                return false;
        
        return true;
    }
    
    public static int Reversed(int n)
    {
        string numReverse="";
        string num2 = Convert.ToString(n);
        for(int i = num2.Length - 1 ; i >= 0 ; i --)
                numReverse += num2[i];
        return Convert.ToInt32(numReverse);
    }
    
    public static bool IsEmirp(int num)
    {
        if(! IsPrime(num))
            return false;
            
        int n2 = Reversed(num);
        
        if (n2 == num)
            return false;
            
        if(! IsPrime(n2))
            return false;
            
        return true;
    }
    
    public static void GetMinMax(int[] data, ref int min, ref int max)
    {
        min = data[0];
        max = data[0];
        
        for(int i = 1 ; i < data.Length ; i ++)
        {
            if (data[i] < min)
                min = data[i];
                
            if (data[i] > max)
                max = data[i];
        }
    }
    
    public static void DrawEmptyParallelogram(int width, int height ,
            char symbol)
    {
        int spaces = 0;
        
        for(int i = 0 ; i < height ; i ++)
        {
            for(int j = 0; j < spaces; j ++)
                Console.Write(" ");
                
            spaces ++;
            
            if(i == 0 || i == height - 1)
            {
                for(int j = 0; j < width ; j ++)
                    Console.Write(symbol);
            }
            else
            {
                Console.Write(symbol);
                for(int j = 0; j < width - 2; j ++)
                    Console.Write(" ");
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
    
    public static bool Contains(string text, char charSearch)
    {
        foreach(char character in text)
            if(character == charSearch)
                return true;
                
        return false;
    }
    
    public static bool ContainsR(string text, char charSearch)
    {
        if (text.Length == 0)
            return false;
            
        if (text.Length == 1)
        { 
            if (text[0] == charSearch)
                return true;
            else
                return false;
        }
            
        return ContainsR(
            text.Substring(1, text.Length - 1), 
            charSearch);
        
    }
    
    
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: emirp / minMax /"
                    + " para /  contains0.");
            return 1;
        }
        else
        {
            switch(args[0])
            {
                case "emirp":
                    if (args.Length == 2)
                    {
                        if (IsEmirp (Convert.ToInt32(args[1])))
                            Console.WriteLine("{0} is an Emirp", args[1]);
                        else
                            Console.WriteLine("{0} is not an Emirp", args[1]);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                
                case "minMax":
                    if (args.Length == 4)
                    {
                        int min = 0;
                        int max = 0;
                        
                        int[] datos = { Convert.ToInt32(args[1]),
                                Convert.ToInt32(args[2]),
                                Convert.ToInt32(args[3]) };
                        
                        GetMinMax (datos, ref min, ref max);
                        Console.WriteLine("Minimum is "+min+" and maximum is "+max);
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
                        DrawEmptyParallelogram(Convert.ToInt32(args[1]),
                                Convert.ToInt32(args[2]),
                                Convert.ToChar(args[3]));
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                        
                case "contains0":
                    if (args.Length == 2)
                    {
                        if ( Contains( 
                                Convert.ToString(args[1]),
                                '0'))
                            Console.WriteLine("There is an {0}", args[2]);
                        else
                            Console.WriteLine("There isn't an {0}", args[2]);
                    }
                    else
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                    
                default:
                    Console.WriteLine("zzzz");
                    return 3;
            }
            return 0;
        }
    }
}
