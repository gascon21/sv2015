// Chen Chao
// 01-01-2016

using System;

public class Ejer09NavBasic
{
    public static char[] ExtraerVocales(string text)
    {
        uint size = 0;
        
        foreach (char c in text)
        {
            if (c == 'a' || c== 'e' || c == 'i' || c == 'o' || c == 'u' || 
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                size++;
        }
        
        char[] vocals = new char[size];
        int position = 0;
        
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'a' || text[i]== 'e' || text[i] == 'i' || 
                    text[i] == 'o' || text[i] == 'u' || text[i] == 'A' || 
                    text[i] == 'E' || text[i] == 'I' || text[i] == 'O' || 
                    text[i] == 'U')
            {
                vocals[position] = text[i];
                position++;
            }
        }
        
        return vocals;
    }
    
    
    public static string ExtraerVocalesNR(string text)
    {
        string vowels = "";

        uint aVowel = 0;
        uint eVowel = 0;
        uint iVowel = 0;
        uint oVowel = 0;
        uint uVowel = 0;
        
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'a' || text[i] == 'A')
                aVowel++;
            if (text[i] == 'e' || text[i] == 'E')
                eVowel++;
            if (text[i] == 'i' || text[i] == 'I')
                iVowel++;
            if (text[i] == 'o' || text[i] == 'O')
                oVowel++;
            if (text[i] == 'u' || text[i] == 'U')
                uVowel++;
        }
        
        if (aVowel > 0)
            vowels += 'a';
        if (eVowel > 0)
            vowels += 'e';
        if (iVowel > 0)
            vowels += 'i';
        if (oVowel > 0)
            vowels += 'o';
        if (uVowel > 0)
            vowels += 'u';

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
