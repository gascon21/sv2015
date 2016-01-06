// Chen Chao
// 01-01-2016

using System;
using System.Text;  // For StringBuilder

public class Ejer07NavBasic
{
    public static string CadenaRepetitiva(char c, int n)
    {
        string text = "";
        
        for (int i = 0; i < n; i++)
            text += c;
            
        return text;
    }
    
    
    public static string CambiarLetra(string text, char c, int position)
    {
        StringBuilder newText = new StringBuilder(text);
        newText[position] = c;
        
        return newText.ToString();
    }
    
    
    public static void Main()
    {
        Console.WriteLine(CadenaRepetitiva('a', 10));
        
        Console.WriteLine(CambiarLetra("Hola", 'j', 2));
    }
}
