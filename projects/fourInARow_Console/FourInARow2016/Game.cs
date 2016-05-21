// Chen Chao, Sacha Laurent Van de Sijpe Bueno
// Pedro Antonio Pérez Paterna y Rubén Blanco Couce
// 19-05-2016

using System;
using System.Collections.Generic;
using System.Threading;

namespace FourInARow2016
{
    class Game : Screen
    {
        private bool redWin;
        private bool redTurn;
        private bool finished;
        private bool leave;
        private int col;
        private Piece[,] pieces;
        private Piece[,] tempPieces;
        private int movHorizontal;
        private int movVertical;
        private int width;
        private int height;

        public Game()
        {
            height = 6;
            width = 7;
            pieces = new Piece[height, width];
            tempPieces = new Piece[height, width];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    tempPieces[i, j] = new Piece(j, i, 2);

            finished = false;
            leave = false;
            redTurn = true;
            redWin = false;
            col = 0;
            movHorizontal = 11;
            movVertical = 6;
            Console.BackgroundColor = ConsoleColor.White;
        }

        // Draw the entire table
        public void DrawTable()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("|          |          |          |     " +
                    "     |          |          |          |");
                Console.WriteLine("|          |          |          |     " +
                    "     |          |          |          |");
                Console.WriteLine("|          |          |          |     " +
                    "     |          |          |          |");
                Console.WriteLine("|          |          |          |     " +
                    "     |          |          |          |");
                Console.WriteLine("|          |          |          |     " +
                    "     |          |          |          |");
                Console.WriteLine("|__________|__________|__________|_____" +
                    "_____|__________|__________|__________|");
            }

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    tempPieces[i, j].Draw();

            Console.ResetColor();
        }

        // Draw the game over text
        public void DrawGameOver()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(1 * movHorizontal + 2,
                2 * movVertical + 5);
            Console.WriteLine(@"   ___  ");
            Console.SetCursorPosition(1 * movHorizontal + 2,
                2 * movVertical + 6);
            Console.WriteLine(@"  / __| ");
            Console.SetCursorPosition(1 * movHorizontal + 2,
                2 * movVertical + 7);
            Console.WriteLine(@" | (_ | ");
            Console.SetCursorPosition(1 * movHorizontal + 2,
                2 * movVertical + 8);
            Console.WriteLine(@"  \___/ ");

            Console.SetCursorPosition(2 * movHorizontal + 2,
                2 * movVertical + 5);
            Console.WriteLine(@"    _   ");
            Console.SetCursorPosition(2 * movHorizontal + 2,
                2 * movVertical + 6);
            Console.WriteLine(@"   /_\  ");
            Console.SetCursorPosition(2 * movHorizontal + 2,
                2 * movVertical + 7);
            Console.WriteLine(@"  / _ \ ");
            Console.SetCursorPosition(2 * movHorizontal + 2,
                2 * movVertical + 8);
            Console.WriteLine(@" /_/ \_\");

            Console.SetCursorPosition(3 * movHorizontal + 2,
                2 * movVertical + 5);
            Console.WriteLine(@" _    _ ");
            Console.SetCursorPosition(3 * movHorizontal + 2,
                2 * movVertical + 6);
            Console.WriteLine(@"|  \/  |");
            Console.SetCursorPosition(3 * movHorizontal + 2,
                2 * movVertical + 7);
            Console.WriteLine(@"| |\/| |");
            Console.SetCursorPosition(3 * movHorizontal + 2,
                2 * movVertical + 8);
            Console.WriteLine(@"|_|  |_|");

            Console.SetCursorPosition(4 * movHorizontal + 2,
                2 * movVertical + 5);
            Console.WriteLine("  ___   ");
            Console.SetCursorPosition(4 * movHorizontal + 2,
                2 * movVertical + 6);
            Console.WriteLine(" | __|  ");
            Console.SetCursorPosition(4 * movHorizontal + 2,
                2 * movVertical + 7);
            Console.WriteLine(" | _|   ");
            Console.SetCursorPosition(4 * movHorizontal + 2,
                2 * movVertical + 8);
            Console.WriteLine(" |___|  ");

            Console.SetCursorPosition(2 * movHorizontal + 2,
                3 * movVertical + 5);
            Console.WriteLine(@"  ___   ");
            Console.SetCursorPosition(2 * movHorizontal + 2,
                3 * movVertical + 6);
            Console.WriteLine(@" / _ \  ");
            Console.SetCursorPosition(2 * movHorizontal + 2,
                3 * movVertical + 7);
            Console.WriteLine(@"| (_) | ");
            Console.SetCursorPosition(2 * movHorizontal + 2,
                3 * movVertical + 8);
            Console.WriteLine(@" \___/  ");

            Console.SetCursorPosition(3 * movHorizontal + 2,
                3 * movVertical + 5);
            Console.WriteLine(@"_     _ ");
            Console.SetCursorPosition(3 * movHorizontal + 2,
                3 * movVertical + 6);
            Console.WriteLine(@"\ \ / / ");
            Console.SetCursorPosition(3 * movHorizontal + 2,
                3 * movVertical + 7);
            Console.WriteLine(@" \ V /  ");
            Console.SetCursorPosition(3 * movHorizontal + 2,
                3 * movVertical + 8);
            Console.WriteLine(@"  \_/   ");

            Console.SetCursorPosition(4 * movHorizontal + 2,
                3 * movVertical + 5);
            Console.WriteLine(@"  ___   ");
            Console.SetCursorPosition(4 * movHorizontal + 2,
                3 * movVertical + 6);
            Console.WriteLine(@" | __|  ");
            Console.SetCursorPosition(4 * movHorizontal + 2,
                3 * movVertical + 7);
            Console.WriteLine(@" | _|   ");
            Console.SetCursorPosition(4 * movHorizontal + 2,
                3 * movVertical + 8);
            Console.WriteLine(@" |___|  ");

            Console.SetCursorPosition(5 * movHorizontal + 2,
                3 * movVertical + 5);
            Console.WriteLine(@"  ___   ");
            Console.SetCursorPosition(5 * movHorizontal + 2,
                3 * movVertical + 6);
            Console.WriteLine(@" | _ \  ");
            Console.SetCursorPosition(5 * movHorizontal + 2,
                3 * movVertical + 7);
            Console.WriteLine(@" |   /  ");
            Console.SetCursorPosition(5 * movHorizontal + 2,
                3 * movVertical + 8);
            Console.WriteLine(@" |_|_\  ");

            Console.ResetColor();
        }

        // Draw the piece position selector
        public void DrawCurrentPiece(int column, bool redTurn)
        {
            // Erase left piece if drawned
            if (column - 1 >= 0)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition((column - 1) * movHorizontal + 4, 1);
                Console.WriteLine("    ");
                Console.SetCursorPosition((column - 1) * movHorizontal + 4, 2);
                Console.WriteLine("    ");
            }

            // Draw current piece selector
            Console.BackgroundColor = redTurn == true ? ConsoleColor.Red :
                ConsoleColor.Yellow;
            Console.SetCursorPosition(column * movHorizontal + 4, 1);
            Console.WriteLine("    ");
            Console.SetCursorPosition(column * movHorizontal + 4, 2);
            Console.WriteLine("    ");

            // Erase right piece if drawned
            if (column + 1 < 7)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition((column + 1) * movHorizontal + 4, 1);
                Console.WriteLine("    ");
                Console.SetCursorPosition((column + 1) * movHorizontal + 4, 2);
                Console.WriteLine("    ");
                Console.ResetColor();
            }

            Console.BackgroundColor = ConsoleColor.White;
        }

        // Return all pieces
        public Piece[,] GetPieces()
        {
            return pieces;
        }
        
        // Changes turn
        public void IAMoved()
        {
            redTurn = true;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        // Get valid position recursively for pieces
        public int GetPosition(Piece[,] pieces, int col, int row)
        {
            if (row == 5)
                return row;
            if (row + 1 < height && pieces[row + 1, col] != null)
                return row;
            return GetPosition(pieces, col, row + 1);
        }

        // Check for pieces
        public void CheckGameStatus()
        {
            for (int i = 0; i < height && !finished; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (pieces[i, j] != null)
                    {
                        if ((j + 3 < width) &&
                                (pieces[i, j + 1] != null &&
                                pieces[i, j + 2] != null &&
                                pieces[i, j + 3] != null) &&
                                (pieces[i, j].Color ==
                                pieces[i, j + 1].Color &&
                                pieces[i, j].Color ==
                                pieces[i, j + 2].Color &&
                                pieces[i, j].Color ==
                                pieces[i, j + 3].Color))
                        {
                            redWin = pieces[i, j].Color == 0 ? true : false;
                            finished = true;
                        }
                        if ((i + 3 < height) &&
                                (pieces[i + 1, j] != null &&
                                pieces[i + 2, j] != null &&
                                pieces[i + 3, j] != null) &&
                                (pieces[i, j].Color ==
                                pieces[i + 1, j].Color &&
                                pieces[i, j].Color ==
                                pieces[i + 2, j].Color &&
                                pieces[i, j].Color ==
                                pieces[i + 3, j].Color))
                        {
                            redWin = pieces[i, j].Color == 0 ? true : false;
                            finished = true;
                        }
                        if ((i + 3 < height && j + 3 < width) &&
                                (pieces[i + 1, j + 1] != null &&
                                pieces[i + 2, j + 2] != null &&
                                pieces[i + 3, j + 3] != null) &&
                                (pieces[i, j].Color ==
                                pieces[i + 1, j + 1].Color &&
                                pieces[i, j].Color ==
                                pieces[i + 2, j + 2].Color &&
                                pieces[i, j].Color ==
                                pieces[i + 3, j + 3].Color))
                        {
                            redWin = pieces[i, j].Color == 0 ? true : false;
                            finished = true;
                        }
                        if ((i + 3 < height && j - 3 >= 0) &&
                                (pieces[i + 1, j - 1] != null &&
                                pieces[i + 2, j - 2] != null &&
                                pieces[i + 3, j - 3] != null) &&
                                (pieces[i, j].Color ==
                                pieces[i + 1, j - 1].Color &&
                                pieces[i, j].Color ==
                                pieces[i + 2, j - 2].Color &&
                                pieces[i, j].Color ==
                                pieces[i + 3, j - 3].Color))
                        {
                            redWin = pieces[i, j].Color == 0 ? true : false;
                            finished = true;
                        }
                    }
                }
            }
        }

        public void Run()
        {
            DrawTable();
            DrawCurrentPiece(col, redTurn);
            do
            {
                CheckGameStatus();
                // Check keys
                ConsoleKeyInfo key;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.LeftArrow && col > 0)
                        col--;
                    if (key.Key == ConsoleKey.RightArrow && col < width - 1)
                        col++;
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        int position = GetPosition(pieces, col, 0);

                        // Add piece at the valid position
                        if (pieces[position, col] == null)
                        {
                            Console.Beep(523, 150);
                            for (int i = 0; i <= position; i++)
                            {
                                // Erase previous piece drawing
                                if (i > 0)
                                    tempPieces[i - 1, col].Draw();

                                // Draw current piece falling
                                pieces[position, col] = new Piece(col, i,
                                    redTurn ? 0 : 1);
                                pieces[position, col].Draw();
                                DrawCurrentPiece(col, redTurn);
                                Thread.Sleep(100);
                            }
                            redTurn = !redTurn;
                        }
                    }
                    DrawCurrentPiece(col, redTurn);

                    if (key.Key == ConsoleKey.Escape)
                    {
                        leave = true;
                        finished = true;
                    }
                }
            }
            while (!finished);

            if (!leave)
            {
                // Erase column selector
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition(col * movHorizontal + 4, 1);
                Console.WriteLine("    ");
                Console.SetCursorPosition(col * movHorizontal + 4, 2);
                Console.WriteLine("    ");

                // Fill table with winner pieces
                for (int i = height - 1; i >= 0; i--)
                    for (int j = 0; j < width; j++)
                    {
                        pieces[i, j] = new Piece(j, i, redWin ? 0 : 1);
                        pieces[i, j].Draw();
                        Thread.Sleep(100);
                    }
                Console.Clear();

                // Clear table
                pieces = null;
                Console.BackgroundColor = ConsoleColor.White;
                DrawTable();
                Console.BackgroundColor = ConsoleColor.White;
                DrawGameOver();
                Console.BackgroundColor = ConsoleColor.White;
                WriteText(42, 'n', redWin ? "Red Player Won!" :
                    "Yellow Player Won!");
                WriteText(44, 'n', "Press enter to continue...");
                Console.ReadLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
