// Jose Muñoz, Monica Esteve, Carla Liarte, José Vicente Leal

using System;
using System.IO;

public class Othello
{
    const int SIZE = 8;
    static bool finished = false;
    static string[,] table = new string[SIZE, SIZE];
    // true X - negras, false O - blancas
    static bool turn = true;

    public static void Init()
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
    public static void Draw()
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
        if (turn)
        {
            CountData();
            Console.WriteLine("Turno de Negras X");
        }
        else
        {
            CountData();
            Console.WriteLine("Turno de Blancas O");
        }
        Console.WriteLine();

    }

    public static void CountData()
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
        Console.WriteLine("Blacks : " + countBlacks + " | Whites : " + countWhites);
    }

    public static void askposition(ref int x, ref int y)
    {
        bool valida = false;
        ConsoleKeyInfo key;
        do
        {

            Console.Write("Inserta la fila: ");
            key = Console.ReadKey();
            valida = IsValidpos(key);
            Console.WriteLine();
        }
        while (!valida && !finished);
        if (!finished)
        {
            if (valida)
            {
                x = Convert.ToInt32(key.KeyChar.ToString());
                valida = false;
            }

            do
            {
                Console.Write("Inserta la columna: ");
                key = Console.ReadKey();
                valida = IsValidpos(key);
                Console.WriteLine();
            }
            while (!valida && !finished);
            if (valida && !finished)
                y = Convert.ToInt32(key.KeyChar.ToString());
        }
    }

    public static bool IsValidpos(ConsoleKeyInfo key)
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

    public static bool CheckFinal()
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
    public static string CheckFin(string[,] t)
    {
        // Blancas O
        // Negras X
        int countBlanca = 0;
        int countNegra = 0;

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                if (t[i, j] == "O")
                    countBlanca++;

                if (t[i, j] == "X")
                    countNegra++;
            }
        }
        if (countBlanca > countNegra)
        {
            return "Ganan las BLANCAS";
        }
        else if (countBlanca == countNegra)
        {
            return "EMPATE";
        }
        else
            return "Ganan las NEGRAS";
    }



    public static void Main(string[] args)
    {
        Init();
        do
        {
            Draw();

            // pide coordenadas
            int row = 1;
            int col = 1;

            askposition(ref row, ref col);

            if (turn && table[row - 1, col - 1] == "-" && !finished)
            {
                table[(row - 1), (col - 1)] = "X";
                turn = !turn;
            }
            else if ((!turn) && table[row - 1, col - 1] == "-" && !finished)
            {
                table[(row - 1), (col - 1)] = "O";
                turn = !turn;
            }

            if (CheckFinal())
            {
                Draw();
                Console.WriteLine(CheckFin(table));
                Console.ReadLine();
            }
        } while (!finished);
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

