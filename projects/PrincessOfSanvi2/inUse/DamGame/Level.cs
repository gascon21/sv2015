namespace DamGame
{
    class Level
    {
        byte tileWidth, tileHeight;
        byte levelWidth, levelHeight;
        byte leftMargin, topMargin;
        string[] levelDescription;

        Image brick1, brick2, brick3, 
            floor, floorL, floorR, ceiling,
            backB1, backB2, torch1, torch2,
            pit1, pit2, pit3, endScreen;

        public Level()
        {
            tileWidth = 80;
            tileHeight = 53;
            levelWidth = 10;
            levelHeight = 10;
            leftMargin = 80;
            topMargin = 50;
            
            // 0 = Empty, 1 = Brick1, 2 = Brick2, 3 = Brick3, 4 = Normal floor
            // 5 = Floor left, 6= right, 7 = Ceiling
            // 10=Upper back brick, 11=lower, 
            // 13 =upper torch 1, 14=2, 15=lower
            // 20=pit side 1, 21=2, 22=3
            levelDescription = new string[10]
            {
                "__________",
                ".   .   . ",
                ",   ,   , ",
                "          ",
                ".  ^.^  . ",
                ",  v,v  , ",
                "-------> <",
                "1111111$ 1",
                "2222222% 2",
                "3333333& 3",
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
        }

        public void DrawOnHiddenScreen()
        {
            for (int row = 0; row < levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    int xPos = leftMargin + col * tileWidth;
                    int yPos = topMargin + row * tileHeight;
                    switch (levelDescription[row][col])
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
                    }
                }
        }

        public bool IsValidMove(int xMin, int yMin, int xMax, int yMax)
        {
            
            // Bottom right corner
            int tileXMax = (xMax - leftMargin) / tileWidth;
            int tileYMax = (yMax - topMargin) / tileHeight;
            char currentTile = levelDescription[tileYMax][tileXMax];
            // Note: if you need to debug, you can add:
            // System.Console.WriteLine(tileXMax+" "+tileYMax+": "+currentTile);
            if ((currentTile == '1') || (currentTile == '2') || (currentTile == '3')
                     || (currentTile == '<') || (currentTile == '-') || (currentTile == '>')
                     || (currentTile == '$') || (currentTile == '%') || (currentTile == '&')
                     || (currentTile == '_') )
                return false;

            // TO DO : Check other possible tiles and other corners

            return true;
        }
    }
}
