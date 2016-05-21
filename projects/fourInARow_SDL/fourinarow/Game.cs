//Sergio Martínez, Miguel Moya, Vicente Cuenca, Adrian Navarro
using System;

class Game
{
    Piece red, yellow;
    Board myBoard = new Board();
    bool turnToRed;
    bool finished;

    public Game()
    {
        turnToRed = true;
        finished = false;
    }
    public bool BoardFull()
    {
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 7; j++)
                if (myBoard.boardPosition[i, j] == ' ')
                    return false;

        return true;
    }

    public bool BoardWinner(Board myBoard, byte x, byte y)
    {
        return false;
    }

    public void Run()
    {
        while (!finished)
        {
            MovePiece();
            Draw();
        }
    }

    public void Draw()
    {
        Hardware.ClearScreen();
        myBoard.DrawOnHiddenScreen();
        if (red != null)
            red.DrawOnHiddenScreen();
        if (yellow != null)
            yellow.DrawOnHiddenScreen();
        Hardware.ShowHiddenScreen();
        Hardware.Pause(50);
    }

    public void MovePiece()
    {
        const int SIZE = 86;
        for (int i = 0; i < 602; i += SIZE)
            if (Mouse.ColisionWith(i, 0, i + SIZE, 520, true))
                if (turnToRed)
                {
                    if (myBoard.SetAt((i / SIZE), 0, 'R'))
                    {
                         red = new Piece(i / SIZE, 0, "data/Red.png");
                        turnToRed = false;
                    }
                }
                else
                {
                    if (myBoard.SetAt((i / SIZE), 0, 'Y'))
                    {
                         yellow = new Piece(i / SIZE, 0, "data/Red.png");
                        turnToRed = true;
                    }
                }
    }

}