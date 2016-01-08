﻿namespace DamGame
{
    class Player : Sprite
    {
        public Player()
        {
            LoadImage("data/player.png");
            x = 50;
            y = 120;
            xSpeed = 8;
            ySpeed = 8;
            width = 32;
            height = 64;
        }

        public void MoveRight()
        {
            x += xSpeed;
        }

        public void MoveLeft()
        {
            x -= xSpeed;
        }

        public void MoveUp()
        {
            y -= ySpeed;
        }

        public void MoveDown()
        {
            y += ySpeed;
        }
    }
}
