namespace DamGame
{
    class Enemy : Sprite
    {
        protected int stepsTillNextFrame;
        protected int currentStep;
        public Enemy(int newX, int newY)
        {
            LoadSequence(LEFT, 
                new string[] { "data/birdL1.png", "data/birdL2.png"});
            LoadSequence(RIGHT,
                new string[] { "data/birdR1.png", "data/birdR2.png" });
            ChangeDirection(LEFT);
            x = newX;
            y = newY;
            xSpeed = 3;
            ySpeed = 3;
            width = 48;
            height = 48;
            stepsTillNextFrame = 5;
            currentStep = 0;
        }

        public override void Move()
        {
            // TO DO: Avoid magic numbers
            if ((x > 1024 - width) || (x < 0))
                xSpeed = -xSpeed;
            x = (short)(x + xSpeed);

            if (xSpeed < 0)
                ChangeDirection(LEFT);
            else
                ChangeDirection(RIGHT);

            currentStep++;
            if (currentStep >= stepsTillNextFrame)
            {
                currentStep = 0;
                NextFrame();
            }
        }
    }
}
