using System;

class Spaced
{
    public static void WriteSpaced(string text)
    {
        foreach (char letra in text)
        {
            Console.Write(letra);
            Console.Write(" ");
        }
    }
    static void Main()
    {
        WriteSpaced("Hello!");
    }
}
