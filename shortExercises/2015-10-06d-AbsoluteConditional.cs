// Absolute value

using System;
public class AbsoluteConditional
{
    public static void Main()
    {
        int number, abs;
    
        Console.Write("Enter the number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        /*
        if (number < 0)
            abs = number * -1;
        else
            abs = number;
        */
        
        abs = number < 0 ? number * -1 : number;
                
        Console.WriteLine("Absolute value: {0}", abs);
    }
}
