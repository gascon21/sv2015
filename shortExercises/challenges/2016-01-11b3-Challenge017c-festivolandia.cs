// Chen Chao
// 11-01-2016

using System;

public class Challenge017
{
    public static void Main()
    {
        byte pruebas = Convert.ToByte(Console.ReadLine()); // pruebas = C
        
        for (byte i = 0; i < pruebas; i++)
        {
            string numero = Console.ReadLine();
            
            string[] numero2 = numero.Split(' ');
            int day = Convert.ToInt32(numero2[0]);
            int month = Convert.ToInt32(numero2[1]);
             
            if ((day == 25 && month == 12) ||
                    (day % 2 == month % 2))
                Console.WriteLine("FESTIVO");
            else
                Console.WriteLine("LABORABLE");
        }
    }
}
