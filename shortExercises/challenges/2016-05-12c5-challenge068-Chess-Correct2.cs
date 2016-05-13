// David Gascón López
// Draw chess

using System;
public class DrawChess
{
    public static void Main()
    {
        string numAndChar;
        do
        {
            numAndChar = Console.ReadLine();
            
            if(numAndChar != "0")
            {
                bool white = true;
                
                string[] arrayNumAndChar = numAndChar.Split(' ');
                
                Console.Write("|");
                for(int i = 0 ; i < Convert.ToInt32(arrayNumAndChar[0]) * 8
                        ; i ++)
                    Console.Write("-");
                Console.WriteLine("|");
                
                for(int row = 0; row < 8 ; row ++)
                {
                    for(int numChar = 1 ; numChar <= Convert.ToInt32(
                                    arrayNumAndChar[0]) ; numChar++)
                    {
                        Console.Write("|");
                        for(int col = 0; col < 8 ; col ++)
                        {
                            if(white)
                            {
                                for(int numCharCell = 1 ; numCharCell <=
                                        Convert.ToInt32(arrayNumAndChar[0])
                                        ; numCharCell++)
                                {
                                    Console.Write(" ");
                                }
                                white=!white;
                            }
                            else
                            {
                                for(int numCharCell = 1 ; numCharCell <=
                                        Convert.ToInt32(arrayNumAndChar[0])
                                        ; numCharCell++)
                                {
                                    Console.Write(arrayNumAndChar[1]);
                                }
                                white=!white;
                            }
                        }
                        if(numChar % Convert.ToInt32(arrayNumAndChar[0]) == 0)
                            white=!white;
                        Console.WriteLine("|");
                    }
                }
                Console.Write("|");
                for(int i = 0 ; i < Convert.ToInt32(arrayNumAndChar[0]) * 8
                        ; i ++)
                    Console.Write("-");
                Console.WriteLine("|");
            }
        }
        while(numAndChar != "0");
    }
}
