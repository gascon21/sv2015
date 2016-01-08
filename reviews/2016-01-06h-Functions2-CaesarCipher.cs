// Chen Chao
// 01-01-2016

using System;

public class Ejer08NavBasic
{
    public static string CifrarCesar(string text)
    {
        string newText = "";
        
        foreach (char c in text)
        {
            if ((c >= 'a' && c < 'x') || (c >= 'A' && c < 'X'))
                newText += Convert.ToChar(c + 3);
            else if ((c >= 'x' && c <= 'z') || (c >= 'X' && c <= 'Z'))
                newText += Convert.ToChar(c - ('z' - 'c'));
        }
        
        return newText.ToString();
    }
    
    
    public static string DescifrarCesar(string text)
    {
        string newText = "";
        
        foreach (char c in text)
        {
            if ((c > 'c' && c <= 'z') || (c > 'C' && c <= 'Z'))
                newText += Convert.ToChar(c - 3);
            else if ((c >= 'a' && c <= 'c') || (c >= 'A' && c <= 'C'))
                newText += Convert.ToChar(c + ('z' - 'c'));
        }
        return newText;
    }
    
    
    public static void Main()
    {
        Console.WriteLine(CifrarCesar("vwxyzVWXYZabcABC"));
        Console.WriteLine(DescifrarCesar("abcdefABCDEFXYZxyz"));
        
        string textoPrueba = "vwxyzVWXYZabcABCabcdefABCDEFXYZxyz";
        if (CifrarCesar(DescifrarCesar(textoPrueba)) != textoPrueba)
            Console.WriteLine("Falla!");
        else
            Console.WriteLine("No falla con el texto de prueba");
    }
}
