// Chen Chao
// 19-05-2016

using System;

public class ReverseWord
{
    public static string Reverse(string t)
    {
        if (t.Length <= 1)
            return t;
            
        return t.Substring(t.Length-1, 1) + Reverse(t.Substring(0, t.Length-1));
    }
    
    public static void Main()
    {
        Console.WriteLine(Reverse("Hola"));
        Console.WriteLine(Reverse("Hola chaval"));
        Console.WriteLine(Reverse("Hola mundo"));
    }
}
