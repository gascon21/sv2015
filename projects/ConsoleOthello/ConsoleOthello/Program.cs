// Console Othello
// 0.01  20-05-2016  Jose Muñoz, Monica Esteve, Carla Liarte, José Vicente Leal: First version
// 0.02  23-05-2016  Nacho: Improved translation to English, created constructor
// 0.03  23-05-2016  Nacho: Board data are char, not string. i,j replaced by col,row.
//                       First approach to ProcessMove.

using System;
using System.IO;

public class Othello
{
    const int SIZE = 8;
    static bool finished = false;
    static char[,] table = new char[SIZE, SIZE];
    // true X - negras, false O - blancas
    static bool whiteTurn = true;

    public Othello()
    {
        for (int row = 0; row < SIZE; row++)
        {
            for (int col = 0; col < SIZE; col++)
            {
                table[col, row] = '-';
            }
        }
        table[3, 3] = 'X';
        table[3, 4] = 'O';
        table[4, 3] = 'O';
        table[4, 4] = 'X';
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
        if (whiteTurn)
        {
            DisplayCounters();
            Console.WriteLine("Black turn (X)");
        }
        else
        {
            DisplayCounters();
            Console.WriteLine("White turn (O)");
        }
        Console.WriteLine();

    }

    public void DisplayCounters()
    {
        int countBlacks = 0;
        int countWhites = 0;

        for (int row = 0; row < SIZE; row++)
        {
            for (int col = 0; col < SIZE; col++)
            {
                if (table[col, row] == 'X')
                {
                    countBlacks++;
                }

                if (table[col, row] == 'O')
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
        char otherPlayerSymbol = playerSymbol == 'X' ? 'O' : 'X';
        int x, y;

        // Horizontal rightwards
        x = col; y = row;
        // If the next cell is not ours
        if ((col < 7) && (table[col + 1, row] == otherPlayerSymbol))
        {
            x ++;
            // Skip the other player's cells
            while ((x < 7) && (table[x, row] == otherPlayerSymbol))
                x++;
            // If the next one is ours, then we can turn those cells
            if ((x < 7) && (table[x, row] == playerSymbol))
                for (int c = col; c <= x; c++)
                    table[c, row] = playerSymbol;

        }

        // TO DO: Process the other directions
    }

    public void Jugada(int x, int y)
    {
        int posStart = x - 1;
        int posEnd = 8;

        for (int row = x; row < posEnd; row++)
        {

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
                if (t[col, row] == 'O')
                    amountOfWhite++;

                if (t[col, row] == 'X')
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

            if (whiteTurn && table[col, row] == '-' && !finished)
            {
                table[col, row] = 'X';
                ProcessMove(col, row, 'X');
                whiteTurn = !whiteTurn;
            }
            else if ((!whiteTurn) && table[col, row] == '-' && !finished)
            {
                table[col, row] = 'O';
                ProcessMove(col, row, 'O');
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


    public static void TempPosition(ref int x, ref int y)
    {
        StreamReader myFile = File.OpenText("EntradaPrueba.txt");
        string line = "";
        do
        {
            line = myFile.ReadLine();
            if (line != null)
            {
                // TO DO
            }
        } while (line != null);
        myFile.Close();
    }
}

