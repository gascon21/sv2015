/// <summary>
///  Home accounting: Class EnhancedConsole
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.16  19-Feb-2016  Ruben Blanco, Nacho:
                          First version (WriteAt)
 ---------------------------------------------------- */

using System;

namespace HomeAccounting2
{
    class EnhancedConsole
    {
        protected static int origX;
        protected static int origY;
        protected static int lastX;
        protected static int lastY;

        public static void SetOrigin(int xOrigin, int yOrigin)
        {
            origX = xOrigin;
            origY = yOrigin;
        }

        public static void WriteAt(int left, int top, string text)
        {
            Console.SetCursorPosition(origX + left, origY + top);
            Console.Write(text);
            lastX = origX + left;
            lastY = origY + top;
        }

        public static void WriteAt(int left, int top, char color, string text)
        {
            SetColor(color);
            WriteAt(left, top, text);
        }

        public static void WriteCenteredAt(int top, char color, string text)
        {
            SetColor(color);
            WriteAt(40-text.Length/2, top, text);
        }

        public static void WriteAtNextRow(string text)
        {
            Console.SetCursorPosition(lastX, lastY+1);
            Console.Write(text);
            lastY++;
        }

        public static void SetColor(char color)
        {
            switch (color)
            {
                case 'b': Console.ForegroundColor = ConsoleColor.Blue; break;
                case 'c': Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 'g': Console.ForegroundColor = ConsoleColor.Green; break;
                case 'r': Console.ForegroundColor = ConsoleColor.Red; break;
                case 'y':  Console.ForegroundColor = ConsoleColor.Yellow; break;
                default: Console.ForegroundColor = ConsoleColor.Gray; break;
            }
        }
    }
}
