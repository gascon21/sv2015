// David Gascón López
// Hexadecimal table

using System;
public class HexadecimalTable
{
    public static void Main()
    {
        int j;
        int i;
        
        for(i = 0 ; i < 256 ; i += 16)
        {
            Console.Write("{0}: ", i);
            for(j = i ; j < i + 16 ; j ++)
            {
                if (i<16)
                    Console.Write ("0");
                
                Console.Write( Convert.ToString(j, 16) );
                Console.Write( " " );
            }
            Console.WriteLine();
        }
    }
}
