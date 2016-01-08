// Chen Chao
// 01-01-2016
// Letras contenidas en una frase

using System;

public class Ejer10NavBasic
{
    public static void Main()
    {
        string[] symbols = 
            {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y",
                "z"};
        uint[] amount = new uint[27];
        
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        
        for (int i = 0; i < symbols.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (symbols[i] == Convert.ToString(text[j]))
                    amount[i]++;
            }
        }
        
        for (int i = 0; i < amount.Length; i++)
            if (amount[i] != 0)
                Console.WriteLine("{0}: {1}", symbols[i], amount[i]);
    }
}
