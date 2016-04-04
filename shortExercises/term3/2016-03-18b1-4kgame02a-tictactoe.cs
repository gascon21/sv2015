// Tic Tac Toe
// PedroAntonioPérezPaterna
// Corrections by Nacho:
// - Correct usage of bidim arrays
// - Display results on screen
// - Stop game when any player wins, not only the second
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
        for(int i=0;i<3;i++)
            for(int j=0;j<3;j++)
                bo[j,i]='.';
    }

    public void Draw()
    {
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(bo[j,i]);
            }
            Console.WriteLine();
        }
    }
    
    public void Play(){
            while(!isGameOver())
            {
                Draw();
                Console.WriteLine("O-Player1");
                Console.WriteLine("X-Player2");
                Console.WriteLine("Enter player1 column (0 to 2)");
                x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter player1 row (0 to 2)");
                y=Convert.ToInt32(Console.ReadLine());
                SetPosition(x,y);
                Draw();
                
                if (isGameOver()) break;
                
                Console.WriteLine("Enter player2 column (0 to 2)");
                x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter player2  row (0 to 2)");
                y=Convert.ToInt32(Console.ReadLine());
                SetPosition(x,y);
                Draw();
            }
        }
        public bool isGameOver()
        {
            if((bo[0,0]=='X') && (bo[0,1]=='X') && (bo[0,2]=='X') || (bo[0,0]=='O') && (bo[0,1]=='O') && (bo[0,2]=='O')){return true;}if((bo[1,0]=='X') && (bo[1,1]=='X') && (bo[1,2]=='X') || (bo[1,0]=='O') && (bo[1,1]=='O') && (bo[1,2]=='O')){return true;}if((bo[2,0]=='X') && (bo[2,1]=='X') && (bo[2,2]=='X') || (bo[2,0]=='O') && (bo[2,1]=='O') && (bo[2,2]=='O')){return true;}if((bo[0,0]=='X') && (bo[1,0]=='X') && (bo[2,0]=='X') || (bo[0,0]=='O') && (bo[1,0]=='O') && (bo[2,0]=='O')){return true;}if((bo[0,1]=='X') && (bo[1,1]=='X') && (bo[2,1]=='X') || (bo[0,1]=='O') && (bo[1,1]=='O') && (bo[2,1]=='O')){return true;}if((bo[0,2]=='X') && (bo[1,2]=='X') && (bo[2,2]=='X') || (bo[0,2]=='O') && (bo[1,2]=='O') && (bo[2,2]=='O')){return true;}if((bo[0,0]=='X') && (bo[1,1]=='X') && (bo[2,2]=='X') || (bo[0,0]=='O') && (bo[1,1]=='O') && (bo[2,2]=='O')){return true;}if((bo[0,2]=='X') && (bo[1,1]=='X') && (bo[2,0]=='X') || (bo[0,2]=='O') && (bo[1,1]=='O') && (bo[2,0]=='O')){return true;}
            return false;
        }
        
        public char GetPiece(int x, int y)
        {
            if((x <= 2) && (x >= 0) && (y >= 0) && (y <= 2))
            {
                return bo[x,y];
            }
            else
            {
                return ' ';
            }
        }
        
        public void SetPosition(int x,int y)
        {
            if(!turn)
            {
                bo[x,y] = 'O';
                turn = true;
            }
            else
            {
                bo[x,y] = 'X';
                turn = false;
            }
        }
    }
