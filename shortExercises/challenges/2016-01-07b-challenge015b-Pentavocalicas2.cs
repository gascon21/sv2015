// Miguel Moya Ortega
// Challenge015

using System;

public class Challenge015
{
    public static bool Pentavocalic(string x)
    {
        if( (x.Contains("a") || x.Contains("A")) && 
                (x.Contains("e")  || x.Contains("E")) && 
                (x.Contains("i") || x.Contains("I")) && 
                (x.Contains("o") || x.Contains("O")) && 
                (x.Contains("u") || x.Contains("U")))
            return true;
        return false;
    }
    
    public static void Main()
    {
        int number = 1;
        
        int trys = Convert.ToInt32(Console.ReadLine() );
        if (number != 0)
        {
            for (int i = 0; i < trys; i++)
            {
                string x = Console.ReadLine();
                
                if (Pentavocalic(x))
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");
            }
        }
}
}
