namespace DamGame
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
    }
}
