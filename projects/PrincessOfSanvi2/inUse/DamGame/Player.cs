namespace DamGame
{
    class Player : Sprite
    {
        public Player()
        {
            LoadImage("data/player.png");
            x = 50;
            y = 120;
            xSpeed = 4;
            ySpeed = 4;
            width = 50;
            height = 107;
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
