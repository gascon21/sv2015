using System;
using System.Collections.Generic;

namespace FourInARow2016
{
    class IA
    {
        private Game myGame;
        private int difficulty;
        private int nextMove;
        private int[] position;
        private int[] priority;

        public IA(Game game, int difficulty)
        {
            myGame = game;
            this.difficulty = difficulty;
        }

        public int[] GetPositionsPriority()
        {
            Piece[] pieces = GetValidPositions();
            Piece[,] table = myGame.GetPieces();

            priority = new int[pieces.Length];
            for (int i = 0; i < pieces.Length; i++)
            {
                for (int row = 0; row < myGame.GetHeight(); row++)
                {
                    for (int col = 0; col < myGame.GetWidth(); col++)
                    {
                        if (pieces[i].X + 3 < myGame.GetWidth() &&
                                pieces[i].Color !=
                                table[pieces[i].X + 1, pieces[i].Y].Color &&
                                table[pieces[i].X + 1, pieces[i].Y].Color ==
                                table[pieces[i].X + 2, pieces[i].Y].Color &&
                                table[pieces[i].X + 1, pieces[i].Y].Color ==
                                table[pieces[i].X + 3, pieces[i].Y].Color)
                            priority[i] = 3;
                        if (pieces[i].X - 3 >= 0 &&
                                pieces[i].Color !=
                                table[pieces[i].X - 1, pieces[i].Y].Color &&
                                table[pieces[i].X - 1, pieces[i].Y].Color ==
                                table[pieces[i].X - 2, pieces[i].Y].Color &&
                                table[pieces[i].X - 1, pieces[i].Y].Color ==
                                table[pieces[i].X - 3, pieces[i].Y].Color)
                            priority[i] = 3;
                        if (pieces[i].Y + 3 < myGame.GetHeight() &&
                                pieces[i].Color !=
                                table[pieces[i].X, pieces[i].Y + 1].Color &&
                                table[pieces[i].X, pieces[i].Y + 1].Color ==
                                table[pieces[i].X, pieces[i].Y + 2].Color &&
                                table[pieces[i].X, pieces[i].Y + 1].Color ==
                                table[pieces[i].X, pieces[i].Y + 3].Color)
                            priority[i] = 3;
                        //if (pieces[i].Y + 3 < myGame.GetHeight() &&
                        //        pieces[i].X + 3 < myGame.GetWidth() &&
                        //        pieces[i].Color !=
                        //        table[pieces[i].X, pieces[i].Y + 1].Color &&
                        //        table[pieces[i].X, pieces[i].Y + 1].Color ==
                        //        table[pieces[i].X, pieces[i].Y + 2].Color &&
                        //        table[pieces[i].X, pieces[i].Y + 1].Color ==
                        //        table[pieces[i].X, pieces[i].Y + 3].Color)
                        //    priority[i] = 3;
                    }
                }
            }
            return priority;
        }
        public int GetPosition(Piece[,] pieces, int col, int row)
        {
            if (row == 5)
                return row;
            if (row + 1 < 6 && pieces[row + 1, col] != null)
                return row;
            return GetPosition(pieces, col, row + 1);
        }

        public Piece[] GetValidPositions()
        {
            Piece[,] pieces = myGame.GetPieces();
            List<Piece> piecesList = new List<Piece>();
            for (int i = 0; i < 7; i++)
            {
                Piece trashPiece = new Piece(i, GetPosition(pieces, i, 0), 0);
            }
            return piecesList.ToArray();
        }

        public int PerformNextMovement()
        {
            int[] positions = new int[0];

            if (difficulty == 0)
            {
                Random rnd = new Random();
                nextMove = rnd.Next(0, positions.Length);
            }
            //else
            //{
            //    for (int i = 0; i < myGame.GetHeight(); i++)
            //        for (int j = 0; j < myGame.GetWidth(); j++)
            //        {

            //        }
            //}

            return nextMove;
        }
    }
}
