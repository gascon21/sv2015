/* Mónica Esteve Fernández
 (2.2.11.2) Crea un programa que escriba los números pares del 2 al 106, 
 excepto los que sean múltiplos de 10, usando "continue".
*/

using System;
public class Even2to106
{
    public static void Main()
    {
        for(int i=2;i<=106;i+=2)
        {
            if (i%10 == 0)
                continue;
            Console.WriteLine(i);
        }
    }
}
