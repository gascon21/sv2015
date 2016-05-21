//Sergio Martínez, Miguel Moya, Vicente Cuenca
class Piece : Sprite
{
    public enum Color { RED, YELLOW };


    public Piece(int x, int y, string i)
    {
        ySpeed = 5;
        image = new Image(i);
    }

    public void MoveTo(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
