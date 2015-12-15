// WriteTitle

using System;
using System.Text;

public class FuncWriteTitle
{
    public static void WriteRepeated(char c, int count)
    {
        Console.Write( new String(c, count) );
        
        // Alternative way:
        // for (int i = 0; i < count; i++)
        //    Console.Write(c);
    }
    
    public static void WriteTitle(string text)
    {
        text = text.ToUpper();
        int length = text.Length * 2 - 1;
        int spaces = 40 - length/2;
        
        WriteRepeated(' ', spaces); WriteRepeated('-', length);
        Console.WriteLine();
        
        WriteRepeated(' ', spaces);         
        foreach( char c in text)
            Console.Write("{0} ",c);
        Console.WriteLine();
            
        WriteRepeated(' ', spaces); WriteRepeated('-', length);
        Console.WriteLine();
    }
    
    
    public static void Main()
    {
        WriteTitle("Welcome!");
    }
}
