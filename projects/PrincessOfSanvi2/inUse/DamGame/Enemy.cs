namespace DamGame
{
    class Enemy : Sprite
    {
        public Enemy(int newX, int newY)
        {
            LoadImage("data/bird.png");
            x = newX;
            y = newY;
            xSpeed = 8;
            ySpeed = 8;
            width = 64;
            height = 64;
        }

        public void Move()
        {
            // TO DO
        }
    }
}
