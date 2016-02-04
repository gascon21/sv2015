namespace DamGame
{
    class Enemy : Sprite
    {
        public Enemy(int newX, int newY)
        {
            LoadImage("data/bird.png");
            x = newX;
            y = newY;
            xSpeed = 3;
            ySpeed = 3;
            width = 48;
            height = 48;
        }

        public override void Move()
        {
            // TO DO: Avoid magic numbers
            if ((x > 1024 - width) || (x < 0))
                xSpeed = -xSpeed;
            x = (short)(x + xSpeed);
        }
    }
}
