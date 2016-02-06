namespace DamGame
{
    class Player : Sprite
    {
        public Player()
        {
            LoadSequence(LEFT,
                new string[] { "data/player.png", "data/player2.png" });
            LoadSequence(RIGHT,
                new string[] { "data/player.png", "data/player2.png" });
            ChangeDirection(LEFT);

            x = 50;
            y = 120;
            xSpeed = 4;
            ySpeed = 4;
            width = 50;
            height = 107;

            stepsTillNextFrame = 6;
        }

        public void MoveRight()
        {
            x += xSpeed;
            ChangeDirection(RIGHT);
            NextFrame();
        }

        public void MoveLeft()
        {
            x -= xSpeed;
            ChangeDirection(LEFT);
            NextFrame();
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
