// Console Othello
// 0.01  20-05-2016  Jose Muñoz, Monica Esteve, Carla Liarte, José Vicente Leal: First version
// 0.02  23-05-2016  Nacho: Improved translation to English, created constructor
// 0.03  23-05-2016  Nacho: Board data are char, not string. i,j -> row, col. First approach to ProcessMove.
// 0.04  23-05-2016  Nacho: Apparently correct tiles flipping. Consts BLACK_PIECE and WHITE_PIECE
// 0.05  27-05-2016  Nacho: User can only choose a valid position

using System;
using System.IO;

public class Othello
{
    const int SIZE = 8;
    const char WHITE_PIECE = 'O';
    const char BLACK_PIECE = 'X';
    bool finished = false;
    char[,] table = new char[SIZE, SIZE];
    bool whiteTurn = false;

    public Othello()
    {
        for (int row = 0; row < SIZE; row++)
        {
            for (int col = 0; col < SIZE; col++)
            {
                table[col, row] = '-';
            }
        }
        table[3, 3] = WHITE_PIECE;
        table[3, 4] = BLACK_PIECE;
        table[4, 3] = BLACK_PIECE;
        table[4, 4] = WHITE_PIECE;
    }

    /// <summary>
    /// Diplay the current state of the board
    /// </summary>
    public void Draw()
    {
        Console.Clear();
        for (int row = 0; row < SIZE; row++)
        {
            if (row == 0)
            {
                Console.Write("  ");
                for (int col = 0; col < SIZE; col++)
                {
                    Console.Write(col + 1 + " ");
                }
                Console.WriteLine();
            }
            Console.Write(row + 1 + " ");
            for (int col = 0; col < SIZE; col++)
            {
                Console.Write(table[col, row] + " ");
            }
            Console.WriteLine();
        }
        DisplayCounters();
        Console.WriteLine();
        if (!whiteTurn)
            Console.WriteLine("Black turn (" + BLACK_PIECE + ")");
        else
            Console.WriteLine("White turn (" + WHITE_PIECE + ")");
    }

    /// <summary>
    /// Display amount of pieces each player has
    /// </summary>
    public void DisplayCounters()
    {
        int countBlacks = 0;
        int countWhites = 0;

        for (int row = 0; row < SIZE; row++)
        {
            for (int col = 0; col < SIZE; col++)
            {
                if (table[col, row] == BLACK_PIECE)
                {
                    countBlacks++;
                }

                if (table[col, row] == WHITE_PIECE)
                {
                    countWhites++;
                }
            }
        }
        Console.WriteLine("Black : " + countBlacks + " | White : " + countWhites);
    }

    /// <summary>
    /// Ask for the next position to move
    /// </summary>
    /// <param name="x">Chosen column</param>
    /// <param name="y">Chosen row</param>
    /// <param name="playerSymbol">Symbol which represents fe current player</param>
    public void AskPosition(ref int x, ref int y, char playerSymbol)
    {
        bool validPosition = false;
        do
        {
            bool validChar = false;
            ConsoleKeyInfo key;
            do
            {
                Console.Write("Enter row (1 to 8): ");
                key = Console.ReadKey();
                validChar = IsInValidRange(key);
                Console.WriteLine();
            }
            while (!validChar && !finished);

            if (!finished)
            {
                if (validChar)
                {
                    x = Convert.ToInt32(key.KeyChar.ToString()) - 1;
                    validChar = false;
                }

                do
                {
                    Console.Write("Enter column (1 to 8): ");
                    key = Console.ReadKey();
                    validChar = IsInValidRange(key);
                    Console.WriteLine();
                }
                while (!validChar && !finished);
                if (validChar && !finished)
                    y = Convert.ToInt32(key.KeyChar.ToString()) - 1;
            }

            if (finished)  // Esc pressed?
                break;

            if (IsValidPosition(x, y, playerSymbol))
                validPosition = true;
            else
                Console.WriteLine("Not a valid position for this player!");
        }
        while (!validPosition);
        // TO DO: Check if it is an acceptable position
        // (which would lead to winning at least one tile)

    }

    /// <summary>
    /// Checks if the key pressed by the user is 1..8 or ESC
    /// </summary>
    /// <param name="key">Key pressed</param>
    /// <returns></returns>
    public bool IsInValidRange(ConsoleKeyInfo key)
    {

        if (key.Key == ConsoleKey.Escape)
            finished = true;
        else
            return (key.KeyChar >= '1') && (key.KeyChar <= '8');

        return false;
    }

    /// <summary>
    /// Process a move in certain coordinates by a certain user:
    /// Flips all the corresponding pieces
    /// </summary>
    /// <param name="col">Column, 0-based</param>
    /// <param name="row">Row, 0-based</param>
    /// <param name="playerSymbol">Char which identifies the user</param>
    public void ProcessMove(int col, int row, char playerSymbol)
    {
        char otherPlayerSymbol = playerSymbol == BLACK_PIECE ?
            WHITE_PIECE : BLACK_PIECE;
        int x, y;

        for (int xIncr = -1; xIncr <= 1; xIncr++)
        {
            for (int yIncr = -1; yIncr <= 1; yIncr++)
            {
                if ((xIncr == 0) && (yIncr == 0))
                    continue;

                x = col; y = row;
                // If the next cell is not ours
                if ((x + xIncr >= 0) && (x + xIncr <= 7) &&
                    (y + yIncr >= 0) && (y + yIncr <= 7) &&
                    (table[x + xIncr, y + yIncr] == otherPlayerSymbol))
                {
                    x += xIncr;
                    y += yIncr;
                    // Skip the other player's cells
                    while ((x + xIncr >= 0) && (x + xIncr <= 7) &&
                        (y + yIncr >= 0) && (y + yIncr <= 7) &&
                        (table[x + xIncr, y + yIncr] == otherPlayerSymbol))
                    {
                        x += xIncr;
                        y += yIncr;
                    }
                    // If the next one is ours, then we can turn those cells
                    if ((x + xIncr >= 0) && (x + xIncr <= 7) &&
                            (y + yIncr >= 0) && (y + yIncr <= 7) &&
                            (table[x + xIncr, y + yIncr] == playerSymbol))
                    {
                        x += xIncr;
                        y += yIncr;
                        for (int c = col, r = row; c != x || r != y; c += xIncr, r += yIncr)
                            table[c, r] = playerSymbol;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Returns true if a certain position is valid for a player
    /// </summary>
    /// <param name="col">Column, 0-based</param>
    /// <param name="row">Row, 0-based</param>
    /// <param name="playerSymbol">Char which identifies the user</param>
    public bool IsValidPosition(int col, int row, char playerSymbol)
    {
        bool valid = false;
        char otherPlayerSymbol = playerSymbol == BLACK_PIECE ?
            WHITE_PIECE : BLACK_PIECE;
        int x, y;

        for (int xIncr = -1; xIncr <= 1; xIncr++)
        {
            for (int yIncr = -1; yIncr <= 1; yIncr++)
            {
                if ((xIncr == 0) && (yIncr == 0))
                    continue;

                x = col; y = row;
                // If the next cell is not ours
                if ((x + xIncr >= 0) && (x + xIncr <= 7) &&
                    (y + yIncr >= 0) && (y + yIncr <= 7) &&
                    (table[x + xIncr, y + yIncr] == otherPlayerSymbol))
                {
                    x += xIncr;
                    y += yIncr;
                    // Skip the other player's cells
                    while ((x + xIncr >= 0) && (x + xIncr <= 7) &&
                        (y + yIncr >= 0) && (y + yIncr <= 7) &&
                        (table[x + xIncr, y + yIncr] == otherPlayerSymbol))
                    {
                        x += xIncr;
                        y += yIncr;
                    }
                    // If the next one is ours, then we can turn those cells
                    if ((x + xIncr >= 0) && (x + xIncr <= 7) &&
                            (y + yIncr >= 0) && (y + yIncr <= 7) &&
                            (table[x + xIncr, y + yIncr] == playerSymbol))
                    {
                        x += xIncr;
                        y += yIncr;
                        for (int c = col, r = row; c != x || r != y; c += xIncr, r += yIncr)
                            valid = true;
                    }
                }
            }
        }
        return valid;
    }

    /// <summary>
    /// Returns true if the board is full
    /// </summary>
    public bool IsBoardFull()
    {
        for (int row = 0; row < SIZE; row++)
        {
            for (int col = 0; col < SIZE; col++)
            {
                if (table[col, row] == '-')
                    return false;
            }
        }
        return true;
    }

    public string GetWinnerInfo(char[,] t)
    {
        // Blancas O
        // Negras X
        int amountOfWhite = 0;
        int amountOfBlack = 0;

        for (int row = 0; row < SIZE; row++)
        {
            for (int col = 0; col < SIZE; col++)
            {
                if (t[col, row] == WHITE_PIECE)
                    amountOfWhite++;

                if (t[col, row] == BLACK_PIECE)
                    amountOfBlack++;
            }
        }
        if (amountOfWhite > amountOfBlack)
        {
            return "WHITE wins";
        }
        else if (amountOfWhite == amountOfBlack)
        {
            return "DRAW!";
        }
        else
            return "BLACK wins";
    }


    /// <summary>
    /// Main game loop
    /// </summary>
    public void Run()
    {
        do
        {
            Draw();

            int row = 1;
            int col = 1;

            if ((!whiteTurn) && table[col, row] == '-' && !finished)
            {
                AskPosition(ref row, ref col, BLACK_PIECE);
                table[col, row] = BLACK_PIECE;
                ProcessMove(col, row, BLACK_PIECE);
                whiteTurn = !whiteTurn;
            }
            else if (whiteTurn && table[col, row] == '-' && !finished)
            {
                AskPosition(ref row, ref col, WHITE_PIECE);
                table[col, row] = WHITE_PIECE;
                ProcessMove(col, row, WHITE_PIECE);
                whiteTurn = !whiteTurn;
            }

            if (IsBoardFull())
            {
                Draw();
                Console.WriteLine(GetWinnerInfo(table));
                Console.ReadLine();
            }
        } while (!finished);
    }


    public static void Main(string[] args)
    {
        Othello o = new Othello();
        o.Run();
    }
}
