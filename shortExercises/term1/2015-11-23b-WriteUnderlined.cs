using System;

class Underline
{
    public static void WriteUnderlined(string text, char c)
    {
        Console.WriteLine(text);
        for (int i = 0; i < text.Length; i++)
            Console.Write(c);
        Console.WriteLine();
    }

    static void Main()
    {
        WriteUnderlined("Hello!", '-');
    }
}
