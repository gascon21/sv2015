// Tic Tac Toe
// PedroAntonioPérezPaterna
// Improved by Nacho: bigger symbols
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
        Console.SetCursorPosition(0,19);
    }
    
    public void Play()
    {
        while(!isGameOver())
        {
            DrawBoard();
            Console.WriteLine("O-Player1  X-Player2");
            Console.Write("Enter player1 column (0 to 2): ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter player1 row (0 to 2): ");
            y=Convert.ToInt32(Console.ReadLine());
            bo[x,y] = 'O';
            DrawBoard();
            
            if (isGameOver()) break;
            
            Console.WriteLine("O-Player1  X-Player2");
            Console.Write("Enter player2 column (0 to 2): ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter player2  row (0 to 2): ");
            y=Convert.ToInt32(Console.ReadLine());
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
        startRow = startRow * 6;
        Console.SetCursorPosition(startCol, startRow);
        Console.Write(" #####");
        Console.SetCursorPosition(startCol, startRow+1);
        Console.Write("##   ##");
        Console.SetCursorPosition(startCol, startRow+2);
        Console.Write("##   ##");
        Console.SetCursorPosition(startCol, startRow+3);
        Console.Write("##   ##");
        Console.SetCursorPosition(startCol, startRow+4);
        Console.Write(" #####");
    }
    
    public void DrawX(int startCol, int startRow)
    {
        startCol = 20 + startCol * 8;
        startRow = startRow * 6;
        Console.SetCursorPosition(startCol, startRow);
        Console.Write("@@   @@");
        Console.SetCursorPosition(startCol, startRow+1);
        Console.Write(" @@ @@");
        Console.SetCursorPosition(startCol, startRow+2);
        Console.Write("  @@@");
        Console.SetCursorPosition(startCol, startRow+3);
        Console.Write(" @@ @@");
        Console.SetCursorPosition(startCol, startRow+4);
        Console.Write("@@   @@");
    }
}
