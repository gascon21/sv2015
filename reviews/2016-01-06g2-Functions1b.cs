// Review of functions, 1

using System;

public class Ejer07NavBasic
{
    public static string CadenaRepetitiva(char c, int n)
    {
        return new String(c, n);
    }
    
    
    public static string CambiarLetra(string text, char c, int position)
    {
        return text.Substring(0, position) +
            c + text.Substring(position+1);
    }
    
    
    public static void Main()
    {
        Console.WriteLine(CadenaRepetitiva('a', 10));
        
        Console.WriteLine(CambiarLetra("Hola", 'j', 2));
    }
}
