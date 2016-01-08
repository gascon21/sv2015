// Goteras

using System;

public class Goteras
{
    public static void Main()
    {
        ulong cases = Convert.ToUInt64( Console.ReadLine() );
        
        for (ulong i = 0; i < cases; i++)
        {
            uint drops = Convert.ToUInt32( Console.ReadLine() );
            
            uint hours = drops / 3600;
            uint seconds = drops % 3600;
            uint minutes = seconds / 60;
            seconds = seconds % 60;
            
            if (hours < 10)
                Console.Write("0");
            Console.Write(hours);
            
            Console.Write(":");
            if (minutes < 10)
                Console.Write("0");
            Console.Write(minutes);
            
            Console.Write(":");
            if (seconds < 10)
                Console.Write("0");
            Console.WriteLine(seconds);
            
        }
        
    }
}
