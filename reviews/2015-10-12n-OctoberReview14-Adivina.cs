// Ruben Blanco
// Program: Bigger or smaller

// Crea un programa en el que el usuario deba adivinar un número del 1 al 100 
// (prefijado en el programa). En cada pasada deberá avisar de si se ha pasado
// o se ha quedado corto.

using System;

public class RubenT2Review14
{
    public static void Main()
    {
        int number, answer;
        
        do
        {
            Console.Write("Insert a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            answer = 44;
            
            if (number < answer)
                Console.WriteLine("Answer is bigger");
            else if (number > answer)
                Console.WriteLine("Answer is smaller");
            else
                Console.WriteLine("Correct!");
        }
        while (number != answer);
            Console.WriteLine();
    }
}
