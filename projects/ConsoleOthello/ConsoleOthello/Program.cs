// Console Othello
// 0.01  20-05-2016  Jose Muñoz, Monica Esteve, Carla Liarte, José Vicente Leal: First version
// 0.02  23-05-2016  Nacho: Improved translation to English, created constructor

using System;
using System.IO;

public class Othello
{
    const int SIZE = 8;
    static bool finished = false;
    static string[,] table = new string[SIZE, SIZE];
    // true X - negras, false O - blancas
    static bool whiteTurn = true;

    public Othello()
    {
        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                table[i, j] = "-";
            }
        }
        table[3, 3] = "X";
        table[3, 4] = "O";
        table[4, 3] = "O";
        table[4, 4] = "X";
    }

    public void Draw()
    {
        Console.Clear();
        for (int i = 0; i < SIZE; i++)
        {
            if (i == 0)
            {
                Console.Write("  ");
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
            Console.Write(i + 1 + " ");
            for (int j = 0; j < SIZE; j++)
            {
                Console.Write(table[i, j] + " ");
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

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                if (table[i, j] == "X")
                {
                    countBlacks++;
                }

                if (table[i, j] == "O")
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

            Console.Write("Enter row: ");
            key = Console.ReadKey();
            valid = IsInValidRange(key);
            Console.WriteLine();
        }
        while (!valid && !finished);
        if (!finished)
        {
            if (valid)
            {
                x = Convert.ToInt32(key.KeyChar.ToString());
                valid = false;
            }

            do
            {
                Console.Write("Enter column: ");
                key = Console.ReadKey();
                valid = IsInValidRange(key);
                Console.WriteLine();
            }
            while (!valid && !finished);
            if (valid && !finished)
                y = Convert.ToInt32(key.KeyChar.ToString());
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



    public void Jugada(int x, int y)
    {
        int posStart = x - 1;
        int posEnd = 8;

        for (int i = x; i < posEnd; i++)
        {

        }

    }

    public bool IsBoardFull()
    {
        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                if (table[i, j] == "-")
                    return false;
            }
        }
        return true;
    }

    public string DisplayWinnerInfo(string[,] t)
    {
        // Blancas O
        // Negras X
        int amountOfWhite = 0;
        int amountOfBlack = 0;

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                if (t[i, j] == "O")
                    amountOfWhite++;

                if (t[i, j] == "X")
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

            if (whiteTurn && table[row - 1, col - 1] == "-" && !finished)
            {
                table[(row - 1), (col - 1)] = "X";
                whiteTurn = !whiteTurn;
            }
            else if ((!whiteTurn) && table[row - 1, col - 1] == "-" && !finished)
            {
                table[(row - 1), (col - 1)] = "O";
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

