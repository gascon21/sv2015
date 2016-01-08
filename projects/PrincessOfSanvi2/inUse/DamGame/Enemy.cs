namespace DamGame
{
    class Enemy : Sprite
    {
        public Enemy(int newX, int newY)
        {
            LoadImage("data/enemy.png");
            x = newX;
            y = newY;
            xSpeed = 8;
            ySpeed = 8;
            width = 64;
            height = 64;
        }

        public void Move()
        {
            // TO DO: Avoid magic numbers
            if ((x > 1024 - width) || (x < 0))
                xSpeed = -xSpeed;
            x = (short)(x + xSpeed);
        }
    }
}
