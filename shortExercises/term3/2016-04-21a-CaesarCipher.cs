// Caesar cipher

using System;

public class CaesarCipher
{
    public static string Cipher(string text, byte shift)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
            if ((text[i] >= 'A') && (text[i] <= 'Z'))
            {
                byte realShift = (byte) ((text[i]-'A' + shift) % 26);
                result += Convert.ToChar('A' + realShift);
            }
            else
                result += text[i];
        return result;
    }
    
    public static string Decipher(string text, byte shift)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
            if ((text[i] >= 'A') && (text[i] <= 'Z'))
            {
                byte realShift = (byte) ((text[i]-'A' + (26-shift)) % 26);
                result += Convert.ToChar('A' + realShift);
            }
            else
                result += text[i];
        return result;
    }
    
    public static void Main()
    {
        Console.WriteLine( "HELLOZ becomes " + Cipher("HELLOZ", 3 ) );
        Console.WriteLine( "KHOORC decodes to " + Decipher("KHOORC", 3 ) );
    }
}


