// Chessboard, first approach (B)
// Draw a board with cells of size 1, using # as a symbol

using System;

class ChessChallenge
{
    static void Main(string[] args)
    {
        bool white = true;
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
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
            }
            Console.WriteLine();  // End of row
            if (white)
                white = false;
            else
                white = true;
        }
    }
}
