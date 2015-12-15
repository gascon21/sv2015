// Ruben Blanco
// Program: ForDoWhileWhile

using System;

public class ForDoWhileWhile
{
    public static void Main()
    {
        int i;
                
        for (i=-51; i>=-100; i-=3)
        {    
            if (i == -66)
                continue;
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        for (i=-50; i>=-100; i--)
        {
            if (i%3 != 0) continue;
            if (i == -66) continue;
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        i=-50;
        while (i>=-100)
        {
            if ((i%3 == 0) && (i != -66))
                Console.Write("{0} ",i);
            i--;
        }
        Console.WriteLine();

        i=-50;
        do
        {
            if ((i%3 == 0) && (i != -66))
                Console.Write("{0} ",i);
            i--;
        }
        while (i>=-100);
        Console.WriteLine();
    

    }  
}
