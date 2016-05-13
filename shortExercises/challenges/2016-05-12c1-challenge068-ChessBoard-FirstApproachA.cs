// Chessboard, first approach (A)
// Draw a board with cells of size 1, using # as a symbol

using System;

class ChessChallenge
{
    static void Main(string[] args)
    {
        bool white = true;
        for (int pos = 0; pos < 64; pos++)
        {
            if (white)
            {
                Console.Write(" ");
                white = false;
            }
            else
            {
                Console.Write("#");
                white = true;
            }
            if (pos % 8 == 7)  // End of row
            {
                Console.WriteLine();
                if (white)
                    white = false;
                else
                    white = true;
            }
        }
    }
}
