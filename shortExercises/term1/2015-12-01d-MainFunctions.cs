// Mónica Esteve
// Functions Main

using System;
public class MainFunctions
{
    public static bool IsLeapyear (int year)
    {
        bool leap = false;
        
        if (year%400 ==0 )
            leap= true;
        if ( year%4 == 0 &&  year%100 != 0 )
            leap= true;
        
        return leap;
    }


    public static void WriteTriangleOfName(string text, int rows )
    {
        int max=rows;

        if(max>text.Length)
            max = text.Length;
        for (int i=1;i<=max;i++)
        {
            for ( int j=0; j<text.Length-i;j++)
                Console.Write(" ");
            Console.WriteLine(text.Substring(text.Length -i ));
        }
    }
    
    
    public static void CountVS(string text, ref int vowels, ref int spaces)
    {
        vowels=0;
        spaces=0;
        
        text = text.ToLower();
        
        for ( int i=0; i < text.Length; i++) 
        {
            if(text[i] == ' ')
                spaces++;
            if( (text[i] == 'a') || (text[i] == 'e') 
                    || (text[i] == 'i') || (text[i] == 'o' )
                    || (text[i] == 'u'))
                vowels++;
        }
    }
    
    
    public static void WritePowers3( int n )
    {
        for (int i=n; i>=0; i--)
            Console.Write( "{0} ", Power3( (uint) i) );
    }
    
    
    public static void WritePowers3r( int n )
    {
        // Base case
        if (n == 0)
        {
            Console.Write("1");
            return;
        }
        
        // General case
        Console.Write( "{0} ", Power3( (uint) n) );
        WritePowers3r( n-1 );
    }
    

    public static int Power3(uint exp)
    {
        int result = 1;
        for (uint i=0; i<exp; i++)
            result *= 3;
        return result;
    }
    
    
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: leap / count / triangle /  power.");
            return 1;
        }
        else
        {
            switch(args[0])
            {
                case "leap":
                    try
                    {
                        ushort year = Convert.ToUInt16(args[1]);
                        if (IsLeapyear(year))
                            Console.WriteLine("It is a leap year");
                        else
                            Console.WriteLine("It is not a leap year");
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    break;
                    
                case "count":
                    if ( args[1].Length <2)
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    else
                    {
                        int v=0, s=0;
                        CountVS(args[1], ref v, ref s);
                        Console.WriteLine("Vowels: {0}, spaces: {1}", v, s);
                    }
                    break;
                    
                case "triangle":
                    if ( args[1].Length <3)
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    else
                        WriteTriangleOfName(args[1],Convert.ToInt32(args[2]));
                    break;

                case "power":
                    if ( args[1].Length <2)
                    {
                        Console.WriteLine("Missing parameters");
                        return 2;
                    }
                    else
                        WritePowers3(Convert.ToInt32(args[1]));
                    break;

            }
            return 0;
        }
    }
    
}
