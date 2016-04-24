/// <summary>
/// Part of DamGame (Princess of Sanvi: a game by students of
/// Multiplaftorm Applications Development at IES San Vicente)
/// 
///  Shot.cs: a shot by the player
///  @author Nacho Cabanes
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.09  15-Apr-2016  Miguel Moya and Gonzalo García Soler, minor corrections by Nacho: 
                        Added a new class Shot for shooting
 ---------------------------------------------------- */

namespace DamGame
{

    class Shot : Sprite
    {
        protected Game myGame;

        public Shot(Game g, int x, int y, int xSpeed)
        {
            LoadSequence(LEFT,
                new string[] { "data/arrowL.png" });
            LoadSequence(RIGHT,
                new string[] { "data/arrowR.png" });

            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            if (xSpeed > 0)
                currentDirection = RIGHT;
            else
                currentDirection = LEFT;
            width = 16;
            height = 16;
            myGame = g;
        }

        public override void Move()
        {
            if (!visible)
                return;

            if ((myGame.IsValidMove(x + xSpeed, y, x + width + xSpeed, y + height))
                && (x > 0) && (x < 1024))
                // TO DO: Avoid magic number 1024
            {
                x += xSpeed;
            }
            else
                Hide();
        }
    }
}
