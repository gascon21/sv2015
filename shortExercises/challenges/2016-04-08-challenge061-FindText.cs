// Challenge 061
// Chen Chao
// 07-04-2016

/*
Entrada 
5
h olaa
hoho la
Hola, hola, hola, Que tal estas? Hola. Bienvenido a este lugar.
hhhhhoooollllaaaa es casi lo mismo que hola pero con las letras repetidas
hhhhhhhhoooooooolllllllaaaaaaa

Salida
Caso #1: 0002
Caso #2: 0003
Caso #3: 0133
Caso #4: 1184
Caso #5: 3136
*/

using System;

public class Reto61
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < casos; i++)
        {
            int cantidad = 0;
            string texto = Console.ReadLine().ToLower();
            
            for (int h = 0; h < texto.Length - 3 && texto.Length >= 4; h++)
                for (int o = h+1; o < texto.Length - 2 && texto[h] == 'h'; o++)
                    for (int l = o+1; l < texto.Length - 1 && texto[o] == 'o'; l++)
                        for (int a = l+1; a < texto.Length && texto[l] == 'l'; a++)
                            if (texto[a] == 'a')
                                cantidad++;
            
            Console.WriteLine("Caso #{0}: {1}", i + 1, (cantidad % 10000).ToString("0000"));
        }
    }
}
