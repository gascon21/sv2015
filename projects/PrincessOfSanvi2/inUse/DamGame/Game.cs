/// <summary>
/// Part of DamGame (Princess of Sanvi: a game by students of
/// Multiplaftorm Applications Development at IES San Vicente)
/// 
///  Game.cs: game logic & game loop 
///  @author Nacho Cabanes, Alumnos DAM IesSanVicente 2015-16
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.09  15-Apr-2016  Miguel Moya and Gonzalo García Soler, minor corrections by Nacho: 
                        Player can shoot to the right and to the left (1 shot a time)
   0.08  15-Apr-2016  Chen, Sacha:  Added new screens (3 total screens)
   0.05  12-Feb-2016  Player can jump and fall
   0.03a 29-Jan-2016  Collisions between enemies and player,
                        Example of collisions with the background
   0.02  08-Jan-2016  Player can be moved in four directions,
                        enemies move on their own
   0.01  03-Jan-2016  Nacho: Basic skeleton for the class
 ---------------------------------------------------- */

using System;

namespace DamGame
{
    class Game
    {
        private Font font18;
        private Player player;
        private Enemy[] enemies;
        private Level currentLevel;
        private bool finished;
        private int numEnemies;
        private int level;
        private Shot myShot;
        private char direction;

        public Game()
        {
            font18 = new Font("data/Joystix.ttf", 18);
            player = new Player(this);
            level = 1;
            Random rnd = new Random();
            numEnemies = 2;
            enemies = new Enemy[numEnemies];
            currentLevel = new Level();
            for (int i = 0; i < numEnemies; i++)
            {
                enemies[i] = new Enemy(currentLevel.GetEnemyX()[i], currentLevel.GetEnemyY()[i]);
                enemies[i].SetSpeed(rnd.Next(1, 5), 0);
            }
                  
            finished = false;
            myShot = new Shot(this, 0, 0, 0);
            myShot.Hide();
            direction = 'R';
        }


        // Update screen
        public void DrawElements()
        {
            Hardware.ClearScreen();

            currentLevel.DrawOnHiddenScreen();
            Hardware.WriteHiddenText("Score: ",
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);
            player.DrawOnHiddenScreen();
            for (int i = 0; i < numEnemies; i++)
                enemies[i].DrawOnHiddenScreen();
            myShot.DrawOnHiddenScreen();
            Hardware.ShowHiddenScreen();
        }


        // Check input by the user
        public void CheckKeys()
        {
            if (Hardware.KeyPressed(Hardware.KEY_UP))
            {
                if (Hardware.KeyPressed(Hardware.KEY_RIGHT))
                {
                    player.JumpRight();
                    direction = 'R';
                }
                else
                if (Hardware.KeyPressed(Hardware.KEY_LEFT))
                {
                    player.JumpLeft();
                    direction = 'L';
                }
                else
                    player.Jump();
            }

            else if (Hardware.KeyPressed(Hardware.KEY_RIGHT))
            {
                player.MoveRight();
                direction = 'R';
            }

            else if (Hardware.KeyPressed(Hardware.KEY_LEFT))
            {
                player.MoveLeft();
                direction = 'L';
            }

            //if (Hardware.KeyPressed(Hardware.KEY_DOWN))
            //    player.MoveDown();

            if ((Hardware.KeyPressed(Hardware.KEY_SPC)) && ( ! myShot.IsVisible() ))
            {
                if (direction == 'R')
                    myShot = new Shot(this, player.GetX()+20, player.GetY(), 10);
                else
                    myShot = new Shot(this, player.GetX(), player.GetY(), -10);
            }

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = true;
        }


        // Move enemies, animate background, etc 
        public void MoveElements()
        {
            player.Move();
            myShot.Move();
            for (int i = 0; i < numEnemies; i++)
                enemies[i].Move();
        }


        // Check collisions and apply game logic
        public void CheckCollisions()
        {
            for (int i = 0; i < numEnemies; i++)
                if (enemies[i].CollisionsWith(myShot))
                {
                    enemies[i].Hide();
                    myShot.Hide();
                }

            for (int i = 0; i < numEnemies; i++)
                if (enemies[i].CollisionsWith(player))
                    finished = true;

            if (player.GetX() + player.GetWidth() >= currentLevel.GetMaxX() &&
                    level < 3)
            {
                level++;
                player.SetX(currentLevel.GetMinX() + 5);
                currentLevel.SetLevel(level);
                for (int i = 0; i < numEnemies; i++)
                {
                    enemies[i].SetX(currentLevel.GetEnemyX()[i]);
                }
            }

            if (player.GetX() <= currentLevel.GetMinX() && level > 0)
            {
                level--;
                player.SetX(currentLevel.GetMaxX() - player.GetWidth() - 5);
                currentLevel.SetLevel(level);
                for (int i = 0; i < numEnemies; i++)
                {
                    enemies[i].SetX(currentLevel.GetEnemyX()[i]); 
                }
            }
        }

        public void PauseTillNextFrame()
        {
            // Pause till next frame (20 ms = 50 fps)
            Hardware.Pause(20);
        }

        public void Run()
        {
            // Game Loop
            while (!finished)
            {
                DrawElements();
                CheckKeys();
                MoveElements();
                CheckCollisions();
                PauseTillNextFrame();
            }
        }

        public bool IsValidMove(int xMin, int yMin, int xMax, int yMax)
        {
            return currentLevel.IsValidMove(xMin, yMin, xMax, yMax);
        } 
        
        public Level GetLevel()
        {
            return currentLevel;
        }   
    }
}
