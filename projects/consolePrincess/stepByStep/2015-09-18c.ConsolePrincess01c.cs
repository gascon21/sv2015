/* 
   Console Princess 
   A console game by students at I.E.S. San Vicente, Spain
*/


// Changes:
// Version 0.01c : Variables, using System
// Version 0.01b : Display text centered on screen (80 cosl, 25 rows)
// Version 0.01a : Just display some text on screen

using System;

public class ConsolePrincess
{
    public static void Main()
    {
        int x = 40;
        int y = 12;
        
        Console.SetCursorPosition(x,y);
        Console.WriteLine("A");
    }
}
