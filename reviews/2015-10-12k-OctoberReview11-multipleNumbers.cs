// Ruben Blanco
// Program: 2 loops

// Crea un programa que, para los números entre el 10 y el 20 (ambos incluidos) 
// diga si son divisibles entre 5, si son divisibles entre 6 y si son divisibles 
// entre 7, usando dos bucles anidados.

using System;

public class RubenT2Review11
{
    public static void Main()
    {
        for (int i=10; i<=20; i++)
            for (int n=5; n<=7; n++)
                if (i % n == 0)
                   Console.WriteLine("{0} can be divided by {1}",
                        i, n);
    }
}
