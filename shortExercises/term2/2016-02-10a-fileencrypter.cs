//Sergio Martínez Mira
using System;
using System.Text;
using System.IO;

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

public class TextEncrypted
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string name = Console.ReadLine();
        
        StreamReader oldFile = File.OpenText(name);
        StreamWriter newFile = File.CreateText(name+".txt");
        
        string newline;
        do
        {
            newline = oldFile.ReadLine();
            if (newline != null)
                newFile.WriteLine(Encrypter.Encrypt(newline));
        }
        while(newline != null);
        
        oldFile.Close();
        newFile.Close();
    }
}
