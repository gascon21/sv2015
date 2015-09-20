/* 
   Console Princess 
   A console game by students at I.E.S. San Vicente, Spain
*/

// Changes:
// Version 0.01g : Clear screen before "drawing each frame"
// Version 0.01f : Allow to move several times, pressing 4 (+Return)
// Version 0.01e : Check if user pressed 4 (+Return) to move left
// Version 0.01d : Read input from the user
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
        int key;
        
        while ( 3 > 2 )  // Always
        {
            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.WriteLine("A");
            
            key = Convert.ToInt32( Console.ReadLine() );
            if (key == 4)
                x = x-1;
        }
    }
}
