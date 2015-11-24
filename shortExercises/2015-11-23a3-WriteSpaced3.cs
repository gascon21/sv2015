using System;

class Spaced
{
    public static void WriteSpaced(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Console.Write(" ");
        }
    }
    static void Main()
    {
        WriteSpaced("Hello!");
    }
}
