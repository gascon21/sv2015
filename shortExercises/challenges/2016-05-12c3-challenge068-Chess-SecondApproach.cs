// Chessboard, second approach

using System;

namespace ChessChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            do
            {
                line = Console.ReadLine();
                string[] parts;
                
                if (line != "0")
                {
                    bool white = true;
                    parts = line.Split(' ');
                    int rep = Convert.ToInt32(parts[0]);

                    for (int row = 0; row < 8; row++)
                    {
                        for (int repetitions = 0; repetitions < rep; repetitions++)
                        {
                            for (int col = 0; col < 8; col++)
                            {
                                if (white)
                                {
                                    for (int k = 0; k < rep; k++)
                                        Console.Write(" ");
                                    white = false;
                                }
                                else
                                {
                                    for (int k = 0; k < rep; k++)
                                        Console.Write(parts[1]);
                                    white = true;
                                }
                            }
                        }
                        if (white)
                            white = false;
                        else
                            white = true;
                    }
                }
            } while (line != "0");
        }
    }
}
