// Cristian Navarrete Moreno
using System;
public class digits
{
    public static void Main()
    {
        int x;
        int cont;
        Console.WriteLine("Number?");
        x = Convert.ToInt32(Console.ReadLine() );
         
        if (x<0)
        {
            Console.WriteLine("Warning: It is a negative number");
            x*=-1;
        }
        for(cont=1; x/10>0; cont++)
            x = x/10;
        
        Console.WriteLine("{0} digits", cont);
    }
}
