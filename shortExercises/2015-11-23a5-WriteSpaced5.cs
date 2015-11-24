using System;

class Spaced
{
    public static void WriteSpaced(string text)
    {
        bool debugging = true;

        if (debugging)
            Console.Write("##");

        for (int i = 0; i < text.Length-1; i++)
        {
            Console.Write(text[i]);
            Console.Write(" ");
        }
        Console.Write(text[text.Length - 1]);

        if (debugging)
            Console.Write("##");
    }
    static void Main()
    {
        WriteSpaced("Hello!");
    }
}
