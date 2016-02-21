/* Num.     Date            By / Changes
 * ----------------------------------------------------------
 * 0.02     19-Feb-2016     Pedro Antonio Pérez, Manuel Coronado And Miguel Moya
 *                              Console Princess Level Class 
 */

using System;

public class Level
{
    //~ protected Enemy myEnemy;
    //~ protected Item  myItem;
    
    byte tileWidth, tileHeight;
    byte levelWidth, levelHeight;
    byte leftMargin, topMargin, rigthMargin, bottomMargin;
    string[] levelDescription;
    
    public Level()
    {
        tileWidth = 1;
        tileHeight = 1;
        levelWidth = 80;
        levelHeight = 24;
        leftMargin = 0;
        rigthMargin = 0;
        bottomMargin = 0;
        topMargin = 0;
        
        levelDescription = new string[24]
        {
            "________________________________________________________________________________",
            "================================================================================",
            "                                                                                ",
            "                                 ++                                             ",
            "                                 ++                                             ",
            "                                                                                ",
            "                ++                                   ++                         ",
            "                ++                                   ++                         ",
            "                                                                                ",
            "                                                                                ",
            "                                   ++                                  ++       ",
            "                                   ++                                  ++       ",
            "                                                                                ",
            "                                                                                ",
            "                    ^^           ^^                                             ",
            "                    $$           $$                                             ",
            "                                                                                ",
            "-----------------------------------------------/            /-------------------",
            "¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬/            /¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬",
            "¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬|            |¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬",
            "##############################################|            |####################",
            "##############################################|            |####################",
            "**********************************************|            |********************",
            "**********************************************|            |********************",
        };
    }
    
    public void Draw()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int row = 0; row < levelHeight; row++)
            for (int col = 0; col < levelWidth; col++)
                {
                    switch (levelDescription[row][col])
                    {
                        case '*': Console.Write('*');break;
                        case '#': Console.Write('#');break;
                        case '¬': Console.Write('¬');break;
                        case '|': Console.Write('|');break;
                        case ' ': Console.Write(' ');break;
                        case '_': Console.Write('_');break;
                        case '=': Console.Write('=');break;
                        case '+': Console.Write('+');break;
                        case '$': Console.Write('$');break;
                        case '^': Console.Write('^');break;
                        case '/': Console.Write('/');break;
                        case '-': Console.Write('-');break;
                    }
                    
                }
    }
    
    public bool IsValidMove(int xMin, int yMin, int xMax, int yMax)
        {
            int tileXMax = (xMax - leftMargin) / tileWidth;
            int tileYMax = (yMax - topMargin) / tileHeight;

            int tileXMax1 = (xMin - leftMargin) / tileHeight;
            int tileYMax1 = (yMax - topMargin) / tileWidth;

            int tileXMin1 = (xMax - rigthMargin) / tileHeight;
            int tileYMin1 = (yMin - bottomMargin) / tileWidth;

            int tileXMin = (xMin - rigthMargin) / tileWidth;
            int tileYMin = (yMin - bottomMargin) / tileHeight;

            char currentTile = levelDescription[tileYMax][tileXMax];
            char currentTile2 = levelDescription[tileYMin][tileXMin];
            char currentTile3 = levelDescription[tileYMin1][tileXMin1];
            char currentTile4 = levelDescription[tileYMax1][tileXMax1];
            
            if ((currentTile == '_') || (currentTile == '¬') || (currentTile == '=')
                    || (currentTile == '#') || (currentTile == '|')
                     || (currentTile == '*'))
                return false;
            if ((currentTile2 == '_') || (currentTile2 == '¬') || (currentTile2 == '=')
                    || (currentTile2 == '#') || (currentTile2 == '|')
                    || (currentTile2 == '*'))
                return false;
            if ((currentTile3 == '_') || (currentTile3 == '¬') || (currentTile3 == '=')
                    || (currentTile3 == '#') || (currentTile3 == '|')
                    || (currentTile3 == '*'))
                return false;
            if ((currentTile4 == '_') || (currentTile4 == '¬') || (currentTile4 == '=')
                    || (currentTile4 == '#') || (currentTile4 == '|')
                    || (currentTile4 == '*'))
                return false;

            return true;
        }
}
