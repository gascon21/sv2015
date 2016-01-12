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
            
            if ((numero2[0] == "25" && numero2[1] == "12") ||
                    (Convert.ToByte(numero2[0]) % 2 == 0 && 
                    Convert.ToByte(numero2[1]) % 2 == 0) ||
                    (Convert.ToByte(numero2[0]) % 2 != 0 && 
                    Convert.ToByte(numero2[1]) % 2 != 0))
                Console.WriteLine("FESTIVO");
            else
                Console.WriteLine("LABORABLE");
        }
    }
}
