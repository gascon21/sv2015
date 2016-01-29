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

        public Game()
        {
            font18 = new Font("data/Joystix.ttf", 18);
            player = new Player();

            Random rnd = new Random();
            numEnemies = 2;
            enemies = new Enemy[numEnemies];
            for (int i = 0; i < numEnemies; i++)
            {
                enemies[i] = new Enemy(rnd.Next(200, 800), rnd.Next(50, 600));
                enemies[i].SetSpeed(rnd.Next(1, 5), 0);
            }

            currentLevel = new Level();
            finished = false;
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
            Hardware.ShowHiddenScreen();
        }


        // Check input by the user
        public void CheckKeys()
        {
            if ((Hardware.KeyPressed(Hardware.KEY_RIGHT))
                    && (currentLevel.IsValidMove(
                        player.GetX() + player.GetSpeedX(), 
                        player.GetY(), 
                        player.GetX() + player.GetWidth() + player.GetSpeedX(), 
                        player.GetY() + player.GetHeight())))
                player.MoveRight();

            if ((Hardware.KeyPressed(Hardware.KEY_LEFT))
                && (currentLevel.IsValidMove(
                        player.GetX() - player.GetSpeedX(),
                        player.GetY(),
                        player.GetX() + player.GetWidth() - player.GetSpeedX(),
                        player.GetY() + player.GetHeight())))
                player.MoveLeft();

            if ((Hardware.KeyPressed(Hardware.KEY_DOWN))
                 && (currentLevel.IsValidMove(
                        player.GetX(),
                        player.GetY() + player.GetSpeedY(),
                        player.GetX() + player.GetWidth(),
                        player.GetY() + player.GetHeight() + player.GetSpeedY())))
                player.MoveDown();

            if ((Hardware.KeyPressed(Hardware.KEY_UP))
                && (currentLevel.IsValidMove(
                        player.GetX(),
                        player.GetY() - player.GetSpeedY(),
                        player.GetX() + player.GetWidth(),
                        player.GetY() + player.GetHeight() - player.GetSpeedY())))
                player.MoveUp();

            if (Hardware.KeyPressed(Hardware.KEY_ESC))
                finished = true;
        }


        // Move enemies, animate background, etc 
        public void MoveElements()
        {
            for (int i = 0; i < numEnemies; i++)
                enemies[i].Move();
        }


        // Check collisions and apply game logic
        public void CheckCollisions()
        {
            for (int i = 0; i < numEnemies; i++)
                if (enemies[i].CollisionsWith(player))
                    finished = true;
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
    }
}
