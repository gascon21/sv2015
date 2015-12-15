//Aitor Pérez Arco
//Limitless numbers with goto
using System;
public class GoTo
{
    public static void Main()
    {
        
        int number=1;
        
    repeat:
        Console.Write("{0} ",number);
        number++;
        goto repeat;
    }
}
