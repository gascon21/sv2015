// Console Othello
// 0.01  20-05-2016  Jose Muñoz, Monica Esteve, Carla Liarte, José Vicente Leal: First version
// 0.02  23-05-2016  Nacho: Improved translation to English, created constructor
// 0.03  23-05-2016  Nacho: Board data are char, not string. i,j -> row, col. First approach to ProcessMove.
// 0.04  23-05-2016  Nacho: Apparently correct tiles flipping. Consts BLACK_PIECE and WHITE_PIECE

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
            Console.WriteLine("Black turn (" + BLACK_PIECE +")");
        else
            Console.WriteLine("White turn (" + WHITE_PIECE +")");
    }

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

    public void AskPosition(ref int x, ref int y)
    {
        bool valid = false;
        ConsoleKeyInfo key;
        do
        {
            Console.Write("Enter row (1 to 8): ");
            key = Console.ReadKey();
            valid = IsInValidRange(key);
            Console.WriteLine();
        }
        while (!valid && !finished);

        if (!finished)
        {
            if (valid)
            {
                x = Convert.ToInt32(key.KeyChar.ToString()) - 1;
                valid = false;
            }

            do
            {
                Console.Write("Enter column (1 to 8): ");
                key = Console.ReadKey();
                valid = IsInValidRange(key);
                Console.WriteLine();
            }
            while (!valid && !finished);
            if (valid && !finished)
                y = Convert.ToInt32(key.KeyChar.ToString()) - 1;
        }

        // TO DO: Check if it is an acceptable position
        // (which would lead to winning at least one tile)

    }

    public bool IsInValidRange(ConsoleKeyInfo key)
    {

        if (key.Key == ConsoleKey.Escape)
            finished = true;
        else
            return (key.KeyChar >= '1') && (key.KeyChar <= '8');

        return false;
    }

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

    public string DisplayWinnerInfo(char[,] t)
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



    public void Run()
    {
        do
        {
            Draw();

            // Ask for coordinates
            int row = 1;
            int col = 1;

            AskPosition(ref row, ref col);

            if ((!whiteTurn) && table[col, row] == '-' && !finished)
            {
                table[col, row] = BLACK_PIECE;
                ProcessMove(col, row, BLACK_PIECE);
                whiteTurn = !whiteTurn;
            }
            else if (whiteTurn && table[col, row] == '-' && !finished)
            {
                table[col, row] = WHITE_PIECE;
                ProcessMove(col, row, WHITE_PIECE);
                whiteTurn = !whiteTurn;
            }

            if (IsBoardFull())
            {
                Draw();
                Console.WriteLine(DisplayWinnerInfo(table));
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
