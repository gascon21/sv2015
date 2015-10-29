// Miguel Moya Ortega

using System;

public class ConvetToHexa
{
    public static void Main()
    {        
        for (int i = 0; i <=255; i++)
        {
            if (i%16 == 0)
            {
                if (i > 0)
                    Console.WriteLine ();
                Console.Write ("{0}: ", i);
            }
            
            if (i<16)
                Console.Write ("0");
                
            Console.Write ("{0} ", Convert.ToString (i,16));
        }
        Console.WriteLine ();
    }
}
