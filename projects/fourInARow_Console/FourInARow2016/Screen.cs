using System;

namespace FourInARow2016
{
    class Screen
    {
        public Screen()
        {
            Console.SetWindowSize(80, 45);
        }

        public void SetColor(char color)
        {
            switch (color)
            {
                case 'b': Console.ForegroundColor = ConsoleColor.Blue; break;
                case 'c': Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 'g': Console.ForegroundColor = ConsoleColor.Green; break;
                case 'r': Console.ForegroundColor = ConsoleColor.Red; break;
                case 'm': Console.ForegroundColor = ConsoleColor.Magenta;break;
                case 'y': Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 'n': Console.ForegroundColor = ConsoleColor.Black; break;
                default: Console.ForegroundColor = ConsoleColor.Gray; break;
            }
        }

        public void WriteText(int top, char color, string text)
        {
            SetColor(color);
            Console.SetCursorPosition(40 - text.Length / 2, top);
            Console.Write(text);
        }
    }
}
