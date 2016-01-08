// 01-01-2016
// ExtraerVocales

using System;

public class Ejer09NavBasic
{
    public static char[] ExtraerVocales(string text)
    {
        string cadenaResultado = "";
        
        foreach (char c in text)
        {
            if (c == 'a' || c== 'e' || c == 'i' || c == 'o' || c == 'u' || 
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            cadenaResultado += c;
        }        
        return cadenaResultado.ToCharArray();
    }
    
    
    public static string ExtraerVocalesNR(string text)
    {
        string vowels = "";
        text = text.ToLower();
        if (text.Contains("a")) vowels += "a";
        if (text.Contains("e")) vowels += "e";
        if (text.Contains("i")) vowels += "i";
        if (text.Contains("o")) vowels += "o";
        if (text.Contains("u")) vowels += "u";
        return vowels;
    }
    
    
    public static void Main()
    {
        string text = "Hooola";
        char[] vocals = ExtraerVocales(text);
        
        foreach (char c in vocals)
            Console.Write(c + " ");
        Console.WriteLine();
        
        Console.WriteLine(ExtraerVocalesNR("Que Tal Estas?"));
    }
}
