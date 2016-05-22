// Aquarium - SDL
// 0.01  20-05-2016  David Gascón, Jorge Montalvo, Indra López: First version
// 0.02  22-05-2016  Nacho: Movement; corrected SetSpeedX and SetSpeedY

namespace Aquarium
{
    class MobileElement : Element
    {
        
        protected int speedX;
        protected int speedY;

        public MobileElement(int x, int y, Image image, int speedX, int speedY) : base(x, y, image)
        {
            this.speedX = speedX;
            this.speedY = speedY;
        }
        public int GetSpeedX()
        {
            return speedX;
        }
        public int GetSpeedY()
        {
            return speedY;
        }
        public void SetSpeedX(int newSpeedX)
        {
            speedX = newSpeedX;
        }
        public void SetSpeedY(int newSpeedY)
        {
            speedY = newSpeedY;
        }

        public override void Move()
        {
            x += speedX;
            y += speedY;
            // Fishes: left to right and vice cersa
            if ((x > 1360) || (x < 0))
                speedX = -speedX;
            // Bubbles: upwards
            if (y < 0)
                y = 800;
        }
    }
}
