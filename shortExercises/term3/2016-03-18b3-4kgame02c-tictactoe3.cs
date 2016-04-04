// Tic Tac Toe
// PedroAntonioPerezPaterna
// Improved by Nacho (2): interactive selection
using System;
public class Tictactoe
{
    public static void Main()
    {
        Board board = new Board();
        board.Play();
    }
}

public class Board
{
    protected int x=0;
    protected int y=0;
    protected bool turn = false;
    protected char[,] bo = new char[3,3];
    public Board()
    {
        for(int row=0;row<3;row++)
            for(int col=0;col<3;col++)
                bo[col,row]='.';
    }

    public void DrawBoard()
    {
        Console.Clear();
        for(int row=0;row<3;row++)
        {
            for(int col=0;col<3;col++)
            {
                if (bo[col,row] == 'O')
                    DrawO(col,row);
                else if (bo[col,row] == 'X')
                    DrawX(col,row);
            }
        }
    }
    
    public void Play()
    {
        while(!isGameOver())
        {
            DrawBoard();
            Choose(out y, out x, 1);
            bo[x,y] = 'O';
            DrawBoard();
            
            if (isGameOver()) break;
            
            Choose(out y, out x, 2);
            bo[x,y] = 'X';
            DrawBoard();
        }
    }
    
    public bool isGameOver()
    {
        if((bo[0,0]=='X') && (bo[0,1]=='X') && (bo[0,2]=='X') || (bo[0,0]=='O') && (bo[0,1]=='O') && (bo[0,2]=='O')){return true;}if((bo[1,0]=='X') && (bo[1,1]=='X') && (bo[1,2]=='X') || (bo[1,0]=='O') && (bo[1,1]=='O') && (bo[1,2]=='O')){return true;}if((bo[2,0]=='X') && (bo[2,1]=='X') && (bo[2,2]=='X') || (bo[2,0]=='O') && (bo[2,1]=='O') && (bo[2,2]=='O')){return true;}if((bo[0,0]=='X') && (bo[1,0]=='X') && (bo[2,0]=='X') || (bo[0,0]=='O') && (bo[1,0]=='O') && (bo[2,0]=='O')){return true;}if((bo[0,1]=='X') && (bo[1,1]=='X') && (bo[2,1]=='X') || (bo[0,1]=='O') && (bo[1,1]=='O') && (bo[2,1]=='O')){return true;}if((bo[0,2]=='X') && (bo[1,2]=='X') && (bo[2,2]=='X') || (bo[0,2]=='O') && (bo[1,2]=='O') && (bo[2,2]=='O')){return true;}if((bo[0,0]=='X') && (bo[1,1]=='X') && (bo[2,2]=='X') || (bo[0,0]=='O') && (bo[1,1]=='O') && (bo[2,2]=='O')){return true;}if((bo[0,2]=='X') && (bo[1,1]=='X') && (bo[2,0]=='X') || (bo[0,2]=='O') && (bo[1,1]=='O') && (bo[2,0]=='O')){return true;}
        return false;
    }
    
    public void DrawO(int startCol, int startRow)
    {
        startCol = 20 + startCol * 8;
        startRow = 1 + startRow * 6;
        At(startCol, startRow,   " #####");
        At(startCol, startRow+1, "##   ##");
        At(startCol, startRow+2, "##   ##");
        At(startCol, startRow+3, "##   ##");
        At(startCol, startRow+4, " #####");
    }
    
    public void DrawX(int startCol, int startRow)
    {
        startCol = 20 + startCol * 8;
        startRow = 1 + startRow * 6;
        At(startCol, startRow,   "@@   @@");
        At(startCol, startRow+1, " @@ @@");
        At(startCol, startRow+2, "  @@@");
        At(startCol, startRow+3, " @@ @@");
        At(startCol, startRow+4, "@@   @@");
    }
    
    public void At(int col, int row, string t)
    {
        Console.SetCursorPosition(col, row);
        Console.Write(t);
    }
    
    public void Choose(out int row, out int col, int turn)
    {
        row = 0; col = 0;
        ConsoleKeyInfo tecla;
        do
        {
            DrawBoard();
            At(col*8 + 24, 0, "|");
            At(18, row*6 + 3, "-");
            
            At(0, 19, "O-Player1  X-Player2");
            At(0, 20, "Choose position, player "+turn+"...");
            
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.RightArrow)
                col = (col+1) % 3;
            if (tecla.Key == ConsoleKey.LeftArrow)
                col = (col+2) % 3;
            if (tecla.Key == ConsoleKey.UpArrow)
                row = (row+2) % 3;
            if (tecla.Key == ConsoleKey.DownArrow)
                row = (row+1) % 3;
        }
        while (tecla.KeyChar != 13);
    }
}
