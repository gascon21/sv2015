// Jose Muñoz
// Mark

using System;
public class Mark2
{
    public static void Main()
    {
        int mark;
        
        Console.WriteLine("Enter the mark");
        mark = Convert.ToInt32(Console.ReadLine());
        
        switch (mark)
        {
            case 0:
                goto case 4;
            case 1:
                goto case 4;
            case 2:
                goto case 4;
            case 3:
                goto case 4;
            case 4:
                Console.WriteLine("Suspenso");
                break;
            case 5:
                Console.WriteLine("Aprobado");
                break;
            case 6:
                Console.WriteLine("Bien");
                break;
            case 7:
                goto case 8;
            case 8:
                Console.WriteLine("Notable");
                break;
            case 9:
                goto case 10;
            case 10:
                Console.WriteLine("Sobresaliente");
                break;
        }
    }
}
