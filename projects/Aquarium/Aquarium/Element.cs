using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Element
    {
        protected int x;
        protected int y;
        protected Image image;

        public Element(int  x,int  y, Image image)
        {
            this.image = image;
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Hardware.DrawHiddenImage(image, x, y);
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }

        public virtual void Move()
        {

        }
    }
}
