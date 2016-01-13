// Miguel Moya Ortega

using System;

public class Window
{
    protected double width;
    protected double height;
    
    public Window(int widthUser, int heightUser)
    {
        width = widthUser;
        height = heightUser;
    }
    
    public void ShowData()
    {
        Console.WriteLine("Widht is " + width + " and height is " + height);
    }
}

// ---------------------

public class WindowTest
{    
    public static void Main()
    {
        Window[] windows= new Window[10];
        
        Random generator = new Random();

        for (int i = 0 ; i < 10; i++)
        {
            int w = generator.Next(40,101);
            int h = generator.Next(90,121);
            windows[i] = new Window(w, h);
        }
        
        for (int i = 0 ; i < 10; i++)
        {
            windows[i].ShowData();
        }
    }
}
