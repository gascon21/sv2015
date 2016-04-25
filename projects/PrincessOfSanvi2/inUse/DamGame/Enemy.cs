/// <summary>
/// Part of DamGame (Princess of Sanvi: a game by students of
/// Multiplaftorm Applications Development at IES San Vicente)
/// 
///  Enemy.cs: logic for the enemy
///  @author Nacho Cabanes
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.04b 06-Feb-2016  Animated movement, frame rate adjusted
   0.04a 04-Feb-2016  Animated movement, first approach (too fast)
   0.03c 04-Feb-2016  Corrected size and speed
   0.02  08-Jan-2016  Nacho: Correct image for the real enemy in the game
   0.01  03-Jan-2016  Nacho: Basic skeleton for the class
 ---------------------------------------------------- */

namespace DamGame
{
    class Enemy : Sprite
    {
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
            
            NextFrame();
        }
    }
}
