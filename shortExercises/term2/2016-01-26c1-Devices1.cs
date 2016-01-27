// Devices (first approach)

using System;

public class Device
{
    protected float speed;
    protected float screenSize;

    public Device(float speed, float screenSize)
    {
        this.speed = speed;
        this.screenSize = screenSize;
    }
    
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetScreenSize(float screenSize)
    {
        this.screenSize = screenSize;
    }

    public float GetScreenSize()
    {
        return screenSize;
    }

    public override string ToString()
    {
        return ""+ speed + "Mb, " + screenSize + "inches";
    }
}

public class Tactile : Device
{
    public Tactile(float speed, float screenSize) : base(speed, screenSize)
    {    
    }
}

public class Smartphone : Tactile
{
    public Smartphone(float speed, float screenSize) : base(speed, screenSize)
    {     
    }

    public override string ToString()
    {
        return "Smartphone, " + base.ToString();
    }
}

public class Tablet : Tactile
{
    public Tablet(float speed, float screenSize) : base(speed, screenSize)
    {    
    }

    public override string ToString()
    {
        return "Tablet, " + base.ToString();
    }
}

public class WithKeyBoard : Device
{
    public WithKeyBoard(float speed, float screenSize) : base(speed, screenSize)
    {    
    }
}

public class Computer : WithKeyBoard
{
    public Computer(float speed, float screenSize) : base(speed, screenSize)
    {    
    }

    public override string ToString()
    {
        return "Computer, " + base.ToString();
    }
} 

public class Program
{
    static void Main(string[] args)
    {
        Device[] devices = new Device[6];

        devices[0] = new Device(256, 3.5f);
        devices[1] = new Tactile(300, 2.5f);
        devices[2] = new Smartphone(12, 5f);
        devices[3] = new Tablet(24, 10);
        devices[4] = new WithKeyBoard(200, 4.5f);
        devices[5] = new Computer(1000, 8.7f);

        for (int i = 0; i < devices.Length; i++)
        {
            Console.WriteLine(devices[i].ToString());
        } 
    }
}  
