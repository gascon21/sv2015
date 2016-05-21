//Sergio Martínez, Miguel Moya, Vicente Cuenca
class Sprite
{
    protected int x, y;
    protected int startX, startY;
    protected int width, height;
    protected int xSpeed, ySpeed;
    protected bool visible;
    protected Image image;
    protected Image[][] sequence;
    protected bool containsSequence;
    protected int currentFrame;
    
    public byte currentDirection;


    public Sprite()
    {
        startX = 480;
        startY = 568;
        width = 64;
        height = 64;
        visible = true;
    }

    public Sprite(string imageName)
        : this()
    {
        LoadImage(imageName);
    }

    public void LoadImage(string name)
    {
        image = new Image(name);
        containsSequence = false;
    }

    public void LoadSequence(byte direction, string[] names)
    {
        int amountOfFrames = names.Length;
        sequence[direction] = new Image[amountOfFrames];
        for (int i = 0; i < amountOfFrames; i++)
            sequence[direction][i] = new Image(names[i]);
        containsSequence = true;
        currentFrame = 0;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetHeight()
    {
        return height;
    }

    public int GetSpeedX()
    {
        return xSpeed;
    }

    public int GetSpeedY()
    {
        return ySpeed;
    }

    public bool IsVisible()
    {
        return visible;
    }

    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
        if (startX == -1)
        {
            startX = x;
            startY = y;
        }
    }

    public void SetSpeed(int newXSpeed, int newYSpeed)
    {
        xSpeed = newXSpeed;
        ySpeed = newYSpeed;
    }

    public void Show()
    {
        visible = true;
    }

    public void Hide()
    {
        visible = false;
    }

    public virtual void Move()
    {
        // To be redefined in subclasses
    }

    public void DrawOnHiddenScreen()
    {
        if (!visible)
            return;

        if (containsSequence)
            Hardware.DrawHiddenImage(
                sequence[currentDirection][currentFrame], x, y);
        else
            Hardware.DrawHiddenImage(image, x, y);
    }

    public void NextFrame()
    {
        currentFrame++;
        if (currentFrame >= sequence[currentDirection].Length)
            currentFrame = 0;
    }

    public void ChangeDirection(byte newDirection)
    {
        if (!containsSequence) return;
        if (currentDirection != newDirection)
        {
            currentDirection = newDirection;
            currentFrame = 0;
        }

    }

    public bool CollisionsWith(Sprite otherSprite)
    {
        return (visible && otherSprite.IsVisible() &&
            CollisionsWith(otherSprite.GetX(),
                otherSprite.GetY(),
                otherSprite.GetX() + otherSprite.GetWidth(),
                otherSprite.GetY() + otherSprite.GetHeight()));
    }


    public bool CollisionsWith(int xStart, int yStart, int xEnd, int yEnd)
    {
        if (visible &&
                (x < xEnd) &&
                (x + width > xStart) &&
                (y < yEnd) &&
                (y + height > yStart)
                )
            return true;
        return false;
    }

    // Check collisions between two rectangles
    public static bool CheckCollisions(
        int r1xStart, int r1yStart, int r1xEnd, int r1yEnd,
        int r2xStart, int r2yStart, int r2xEnd, int r2yEnd)
    {
        if ((r2xStart < r1xEnd) &&
                (r2xEnd > r1xStart) &&
                (r2yStart < r1yEnd) &&
                (r2yEnd > r1yStart)
                )
            return true;
        else
            return false;
    }

    public void Restart()
    {
        x = startX;
        y = startY;
    }
}
