using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            newSpeedX = speedX;
        }
        public void SetSpeedY(int newSpeedY)
        {
            newSpeedY = speedY;
        }

        public override void Move()
        {
            
        }
    }
}
