using System;

public class Image
{
    // Attributes
    protected char symbol;
    protected char symbol2;
    protected ConsoleColor color;

    public Image( char s1, char s2, ConsoleColor c)
    {
        symbol = s1;
        symbol2 = s2;
        color = c;
    }

    public char GetSymbol1()
    {
        return symbol;
    }

    public char GetSymbol2()
    {
        return symbol2;
    }

    public ConsoleColor GetColor()
    {
        return color;
    }
}
