using System;

namespace FourInARow2016
{
    class Piece
    {
        static int movVertical = 6;
        static int movHorizontal = 11;

        public int X { get; }
        public int Y { get; }
        public int Color { get; }

        public Piece(int x, int y, int color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public void Draw()
        {
            Console.BackgroundColor = Color == 0 ? ConsoleColor.Red :
                Color == 1 ? ConsoleColor.Yellow : ConsoleColor.White;
            Console.SetCursorPosition(X * movHorizontal + 3,
                Y * movVertical + 5);
            Console.WriteLine("      ");
            Console.SetCursorPosition(X * movHorizontal + 2,
                Y * movVertical + 6);
            Console.WriteLine("        ");
            Console.SetCursorPosition(X * movHorizontal + 2,
                Y * movVertical + 7);
            Console.WriteLine("        ");
            Console.SetCursorPosition(X * movHorizontal + 3,
                Y * movVertical + 8);
            Console.WriteLine("      ");
        }
    }

}
