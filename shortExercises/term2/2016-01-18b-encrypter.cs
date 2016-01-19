using System;
using System.Text;

public class Encrypter
{
    public static string Encrypt(string t)
    {
        StringBuilder text = new StringBuilder(t);
        for(int i=0; i<t.Length; i++)
            text[i] ++;
        return text.ToString();
    }
    
    public static string Decrypt(string t)
    {
        StringBuilder text = new StringBuilder(t);
        for(int i=0; i<t.Length; i++)
            text[i] --;
        return text.ToString();
    }
    
}

public class EncrypterTest
{
    public static void Main()
    {
        string newText = Encrypter.Encrypt("Hola");
        Console.WriteLine("Hola becomes {0}", newText);
        
        Console.WriteLine("And it decrypts to {0}", 
            Encrypter.Decrypt(newText));
    }
}
