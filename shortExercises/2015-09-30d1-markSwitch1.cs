// Jose Muñoz
// Mark

using System;
public class Mark
{
    public static void Main()
    {
        int mark;
        
        Console.WriteLine("Enter the mark");
        mark = Convert.ToInt32(Console.ReadLine());
        
        switch (mark)
        {
            case 0:
                Console.WriteLine("Suspenso");
                break;
            case 1:
                Console.WriteLine("Suspenso");
                break;
            case 2:
                Console.WriteLine("Suspenso");
                break;
            case 3:
                Console.WriteLine("Suspenso");
                break;
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
                Console.WriteLine("Notable");
                break;
            case 8:
                Console.WriteLine("Notable");
                break;
            case 9:
                Console.WriteLine("Sobresaliente");
                break;
            case 10:
                Console.WriteLine("Sobresaliente");
                break;
        }
    }
}
