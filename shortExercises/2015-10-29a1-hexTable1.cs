// Miguel Moya Ortega

using System;

public class ConvetToHexa
{
    public static void Main()
    {
        
        Console.Write ("0: ");
        for (int i = 0; i <=255; i++)
        {
            if (i<16)
                Console.Write ("0");
                
            Console.Write ("{0} ", Convert.ToString (i,16));
            
            if (i%16 == 15)
            {
                Console.WriteLine ();
                if (i < 255)
                    Console.Write ("{0}: ", i+1);
            }
        }
        Console.WriteLine ();
    }
}
