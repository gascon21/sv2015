//Sergio Martínez, Miguel Moya, Vicente Cuenca
class Board : Sprite
{
    public char[,] boardPosition;

    // Creation of an empty board
    public Board()
    {
        LoadImage("data/board.png");
        boardPosition = new char[6, 7];

        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 7; j++)
                boardPosition[i, j] = ' ';
    }

    public char GetPiece(int x, int y)
    {
        return boardPosition[y, x];
    }

    public bool SetAt(int x, int y, char piece)
    {
        if (avaibleMove(x, y))
        {
            boardPosition[x, y] = piece;
            return true;
        }
        return false;
    }

    public bool avaibleMove(int x, int y)
    {
        if (boardPosition[x, y] == ' ')
            return true;

        return false;
    }

    public bool Finish()
    {
        int redCounter = 0;
        int whiteCounter = 0;
        for (int i = 0; i < 7; i++)
            for (int j = 0; j < 6; j++)
            {
                if (boardPosition[i, j] == 'R')
                    redCounter++;
                if (boardPosition[i, j] == 'Y')
                    whiteCounter++;
            }
            if (redCounter == 4)
            {
                return true;
            }
            if (whiteCounter == 4)
            {
                return true;
            }
            whiteCounter = 0;
            redCounter = 0;
        return false;
    }
}

