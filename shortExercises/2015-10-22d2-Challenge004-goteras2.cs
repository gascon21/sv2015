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
            
            Console.WriteLine("{0}:{1}:{2}",
                hours.ToString("00"), 
                minutes.ToString("00"), 
                seconds.ToString("00"));
        }
        
    }
}
