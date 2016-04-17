/// <summary>
/// Part of DamGame (Princess of Sanvi: a game by students of
/// Multiplaftorm Applications Development at IES San Vicente)
/// 
///  Level.cs: a level (a screen) from the game
///  @author Nacho Cabanes
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.08  15-Apr-2016  Chen, Sacha, Added new screens, and predefined coords for enemies
   0.03c 04-Feb-2016  Nacho: Corrected tileHeight, more exhaustive IsValidMove
   0.03b 30-Jan-2016  Added more cell types in IsValidMove
   0.03a 29-Jan-2016  Completed IsValidMove checking rectangular collisions
   0.02b 23-Jan-2016  Nacho: Minor corrections
   0.02  22-Jan-2016  Nacho: Extracted from the main program
 ---------------------------------------------------- */

namespace DamGame
{
    class Level
    {
        byte tileWidth, tileHeight;
        byte levelWidth, levelHeight;
        byte leftMargin, topMargin;
        string[][] levelDescription;
        int currentLevel;
        Image brick1, brick2, brick3, 
            floor, floorL, floorR, ceiling,
            backB1, backB2, torch1, torch2,
            pit1, pit2, pit3, endScreen;
        int maxX, minX;
        int[] enemyCoordsX;
        int[] enemyCoordsY;
        int enemyCounter;

        public Level()
        {
            levelDescription = new string[3][];
            tileWidth = 80;
            tileHeight = 64;
            levelWidth = 10;
            levelHeight = 10;
            leftMargin = 80;
            topMargin = 50;
            minX = leftMargin;
            maxX = tileWidth * levelWidth + leftMargin;
            currentLevel = 1;
            enemyCoordsX = new int[2];
            enemyCoordsY = new int[2];
            enemyCounter = 0;
            // 0 = Empty, 1 = Brick1, 2 = Brick2, 3 = Brick3, 4 = Normal floor
            // 5 = Floor left, 6= right, 7 = Ceiling
            // 10=Upper back brick, 11=lower, 
            // 13 =upper torch 1, 14=2, 15=lower
            // 20=pit side 1, 21=2, 22=3
            levelDescription[0] = new string[10]
            {
                "__________",
                "1   .   . ",
                "1 * ,   , ",
                "1     *   ",
                "1  ^.  .^ ",
                "1  v,  ,v ",
                "1-->  <---",
                "111$  1111",
                "222%  2222",
                "333&  3333",
            };
            levelDescription[1] = new string[10]
            {
                "__________",
                ".   .   .*",
                ",   ,   , ",
                "       *  ",
                ".  ^.^  . ",
                ",  v,v  , ",
                "-------> <",
                "1111111$ 1",
                "2222222% 2",
                "3333333& 3",
            };
            levelDescription[2] = new string[10]
            {
                "__________",
                ". * .   .1",
                ",   , * ,1",
                "         1",
                ".  ^.   .1",
                ",  v,   ,1",
                "---------1",
                "1111111111",
                "2222222222",
                "3333333333",
            };

            brick1 = new Image("data\\tileBrick01.png");
            brick2 = new Image("data\\tileBrick02.png");
            brick3 = new Image("data\\tileBrick03.png");
            floor = new Image("data\\tileFloor1.png");
            floorL = new Image("data\\tileFloorLeft.png");
            floorR = new Image("data\\tileFloorPit.png");
            ceiling = new Image("data\\ceiling.png");
            backB1 = new Image("data\\backBrick01.png");
            backB2 = new Image("data\\backBrick02.png");
            torch1 = new Image("data\\tileTorch1.png");
            torch2 = new Image("data\\tileTorch2a.png");
            pit1 = new Image("data\\tilePit01.png");
            pit2 = new Image("data\\tilePit02.png");
            pit3 = new Image("data\\tilePit03.png");
            endScreen = new Image("data\\welcomeText.png");
            SetEnemyCoords();
        }

        public void SetLevel(int level)
        {
            currentLevel = level;
            enemyCounter = 0;
            SetEnemyCoords();
        }

        public int GetMaxX()
        {
            return maxX;
        }

        public int GetMinX()
        {
            return minX;
        }

        public int[] GetEnemyX()
        {
            return enemyCoordsX;
        }

        public int[] GetEnemyY()
        {
            return enemyCoordsY;
        }

        public void SetEnemyCoords()
        {
            for (int row = 0; row < levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    int xPos = leftMargin + col * tileWidth;
                    int yPos = topMargin + row * tileHeight;

                    if (levelDescription[currentLevel][row][col] == '*' && enemyCounter < 2)
                    {        
                        enemyCoordsX[enemyCounter] = xPos;
                        enemyCoordsY[enemyCounter] = yPos;
                        enemyCounter++; 
                    }
                }
        }

        public void DrawOnHiddenScreen()
        {   
            for (int row = 0; row < levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    int xPos = leftMargin + col * tileWidth;
                    int yPos = topMargin + row * tileHeight;
                    
                    switch (levelDescription[currentLevel][row][col])
                    {
                        case '1': Hardware.DrawHiddenImage(brick1, xPos, yPos); break;
                        case '2': Hardware.DrawHiddenImage(brick2, xPos, yPos); break;
                        case '3': Hardware.DrawHiddenImage(brick3, xPos, yPos); break;
                        case '-': Hardware.DrawHiddenImage(floor, xPos, yPos); break;
                        case '<': Hardware.DrawHiddenImage(floorL, xPos, yPos); break;
                        case '>': Hardware.DrawHiddenImage(floorR, xPos, yPos); break;
                        case '_': Hardware.DrawHiddenImage(ceiling, xPos, yPos); break;
                        case '.': Hardware.DrawHiddenImage(backB1, xPos, yPos); break;
                        case ',': Hardware.DrawHiddenImage(backB2, xPos, yPos); break;
                        case '^': Hardware.DrawHiddenImage(torch2, xPos, yPos); break;
                        case 'v': Hardware.DrawHiddenImage(torch1, xPos, yPos); break;
                        case '$': Hardware.DrawHiddenImage(pit1, xPos, yPos); break;
                        case '%': Hardware.DrawHiddenImage(pit2, xPos, yPos); break;
                        case '&': Hardware.DrawHiddenImage(pit3, xPos, yPos); break;
                        case '*':
                            if (enemyCounter < 2)
                            {
                                enemyCoordsX[enemyCounter] = xPos;
                                enemyCoordsY[enemyCounter] = yPos;
                                enemyCounter++;
                            }
                            break;
                    }
                }
        }

        public bool IsValidMove(int xMin, int yMin, int xMax, int yMax)
        {
            for (int row = 0; row < levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    char tileType = levelDescription[currentLevel][row][col];
                    // If we don't need to check collisions with this tile, we skip it
                    if ((tileType == ' ')  // Empty space
                            || (tileType == '.') || (tileType == ',')  // Bricks in the back
                            || (tileType == 'v') || (tileType == '^')) // Torches
                        continue;
                    // Otherwise, lets calculate its corners and check rectangular collisions
                    int xPos = leftMargin + col * tileWidth;
                    int yPos = topMargin + row * tileHeight;
                    int xLimit = leftMargin + (col+1) * tileWidth;
                    int yLimit = topMargin + (row+1) * tileHeight;

                    if (Sprite.CheckCollisions(
                            xMin, yMin, xMax, yMax,  // Coords of the sprite
                            xPos, yPos, xLimit, yLimit)) // Coords of current tile
                        return false;
                    }
            // If we have not collided with anything... then we can move
            return true;
        }
    }
}
