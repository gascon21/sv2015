using System;

class Spaced
{
    public static void WriteSpaced(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("{0} ",text[i]);
        }
    }
    static void Main()
    {
        WriteSpaced("Hello!");
    }
}
