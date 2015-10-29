// Pedro Antonio Pérez
using System;
public class hexTable
{
    public static void Main()
    {
        byte n = 0;
        
        for(int row = 1;row<=16;row++)
        {
            Console.Write("{0}:",n);
            for(int col = 1;col<=16;col++)
            {
                if (n<16)
                    Console.Write ("0");
                
                Console.Write("{0} ",Convert.ToString(n,16));
                n++;
            }
            Console.WriteLine();
        }
    }
}
