/*
   Console Princess
   A console game by students at I.E.S. San Vicente, Spain
*/

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
                if (x > 0)
                    x = x-1;

            if (key == 6)
                if (x < 79)
                    x = x+1;

            if (key == 8)
                if (y > 0)
                    y = y-1;

            if (key == 2)
                if (y < 24)
                    y = y+1;
        }
    }
}
