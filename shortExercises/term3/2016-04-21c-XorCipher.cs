// XOR cipher

using System;

public class XorCipher
{
    public static string Cipher(string text, byte key)
    {
        string result = "";
        foreach (char c in text)
            result += (char) (c ^ key);
        return result;
    }
    
    public static string Decipher(string text, byte key)
    {
        return Cipher(text,key);
    }
    
    public static void Main()
    {
        Console.WriteLine( "HELLOZ becomes " + 
            Cipher("HELLOZ", 1 ) );
        Console.WriteLine( "and it returns to " + 
            Decipher( Cipher("HELLOZ", 1 ), 1 ));
    }
}


