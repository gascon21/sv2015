// Tic Tac Toe
// PedroAntonioPerezPaterna
// Improved by Nacho (3): more efficiente IsGameOver
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
        while(!IsGameOver())
        {
            DrawBoard();
            Choose(out y, out x, 1);
            bo[x,y] = 'O';
            DrawBoard();
            
            if (IsGameOver()) break;
            
            Choose(out y, out x, 2);
            bo[x,y] = 'X';
            DrawBoard();
        }
    }
    
    public bool IsGameOver()
    {
        // A player has won?
        for (int row=0; row<3; row++)
            if((bo[0,row]==bo[1,row]) && (bo[0,row]==bo[2,row]) && (bo[0,row]!='.')) return true;
        for (int col=0; col<3; col++)
            if((bo[col,0]==bo[col,1]) && (bo[col,0]==bo[col,2]) && (bo[col,0]!='.')) return true;
        if((bo[0,0]==bo[1,1]) && (bo[0,0]==bo[2,2]) && (bo[1,1]!='.')) return true;
        if((bo[2,0]==bo[1,1]) && (bo[2,0]==bo[0,2]) && (bo[1,1]!='.')) return true;
        // Draw?
        int spacesRemaining = 0;
        for (int row=0; row<3; row++)
            for (int col=0; col<3; col++)
                if (bo[col,row]=='.')
                    spacesRemaining++;
        if (spacesRemaining>0)
            return false;
        return true;
    }
    
    public void DrawO(int startCol, int startRow)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        startCol = 20 + startCol * 8;
        startRow = 1 + startRow * 6;
        At(startCol, startRow,   " #####");
        At(startCol, startRow+1, "##   ##");
        At(startCol, startRow+2, "##   ##");
        At(startCol, startRow+3, "##   ##");
        At(startCol, startRow+4, " #####");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    
    public void DrawX(int startCol, int startRow)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        startCol = 20 + startCol * 8;
        startRow = 1 + startRow * 6;
        At(startCol, startRow,   "@@   @@");
        At(startCol, startRow+1, " @@ @@");
        At(startCol, startRow+2, "  @@@");
        At(startCol, startRow+3, " @@ @@");
        At(startCol, startRow+4, "@@   @@");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    
    public void At(int col, int row, string t)
    {
        Console.SetCursorPosition(col, row);
        Console.Write(t);
    }
    
    public void Choose(out int row, out int col, int turn)
    {
        bool validMove = false;
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
            if (tecla.Key == ConsoleKey.RightArrow) col = (col+1) % 3;
            if (tecla.Key == ConsoleKey.LeftArrow) col = (col+2) % 3;
            if (tecla.Key == ConsoleKey.UpArrow) row = (row+2) % 3;
            if (tecla.Key == ConsoleKey.DownArrow) row = (row+1) % 3;
            if ((tecla.KeyChar == 13) && (bo[col,row]=='.')) validMove = true;
        }
        while (! validMove);
    }
}
