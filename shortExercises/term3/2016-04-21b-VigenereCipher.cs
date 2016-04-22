// Vigenere cipher

using System;

public class VigenereCipher
{
    public static string Cipher(string text, string key)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
            if ((text[i] >= 'A') && (text[i] <= 'Z'))
            {
                byte realShift = (byte) ((text[i]-'A' + key[i % key.Length]-'A') % 26);
                result += Convert.ToChar('A' + realShift);
            }
            else
                result += text[i];
        return result;
    }
    
    public static string Decipher(string text, string key)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
            if ((text[i] >= 'A') && (text[i] <= 'Z'))
                result += Convert.ToChar('A' + 
                    ((text[i]-'A' + (26-(key[i % key.Length]-'A'))) % 26));
            else
                result += text[i];
        return result;
    }
    
    public static void Main()
    {
        Console.WriteLine( "ATTACKATDAWN + LEMON becomes " + 
            Cipher("ATTACKATDAWN", "LEMON" ) );
        Console.WriteLine( "LXFOPVEFRNHR + LEMON decodes to " + 
            Decipher("LXFOPVEFRNHR", "LEMON" ) );
    }
}


