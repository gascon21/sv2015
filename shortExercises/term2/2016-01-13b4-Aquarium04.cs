//Monica
//Carla
//Juan
//Sacha

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------

class FishBowl
{
    protected Bubles b1;
    protected Fishes f1;
    protected GreenFish g1;
    protected Stone s1;
    public static void Main()
    {
        
    }

    public void MoveElements()
    {

    }

    public void CheckCollisions()
    {

    }

    public void PaintElements()
    {

    }
}

// --------------------------------------

class Bubles : Sprite
{
    public override void Move()
    {

    }
}

// --------------------------------------

class Fishes : Sprite
{
    public Fishes()
    {

    }
    public override void Move()
    {

    }
}

// --------------------------------------
 
class GreenFish : Fishes
{
    public override void Move()
    {

    }
}

// --------------------------------------

class Plants : Sprite
{
    public override void Move()
    {

    }
}

// --------------------------------------

    class Sprite
    {
        protected int x;
        protected int y;
        protected string image;
        
        public Sprite()
        {

        }
        public Sprite(int newX, int newY, string newImage)
        {
            x = newX;
            y = newY;
            image = newImage;
        }

        public void Paint()
        {
            //Console.WriteLine(image);
        }

        public virtual void Move()
        {

        }
    }

// --------------------------------------

 
class Stone : Sprite
{

}
 
// --------------------------------------

 
class YellowFish : Fishes
{
    public override void Move()
    {

    }
}

