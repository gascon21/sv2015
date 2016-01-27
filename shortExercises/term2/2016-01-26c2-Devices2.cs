// Devices (completed)

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
        return "" + speed + "MHz, " + screenSize + "inches";
    }
}

// -------------------

public class Tactile : Device
{
    public Tactile(float speed, float screenSize) 
        : base(speed, screenSize)
    {    
    }
}

// -------------------

public class Smartphone : Tactile
{
    public Smartphone(float speed, float screenSize) 
        : base(speed, screenSize)
    {     
    }

    public override string ToString()
    {
        return "Smartphone, " + base.ToString();
    }
}

// -------------------

public class Tablet : Tactile
{
    public Tablet(float speed, float screenSize) 
        : base(speed, screenSize)
    {    
    }

    public override string ToString()
    {
        return "Tablet, " + base.ToString();
    }
}

// -------------------

public class WithKeyBoard : Device
{
    public WithKeyBoard(float speed, float screenSize) 
        : base(speed, screenSize)
    {    
    }
}

// -------------------

public class Computer : WithKeyBoard
{
    public Computer(float speed, float screenSize) 
        : base(speed, screenSize)
    {    
    }

    public override string ToString()
    {
        return "Computer, " + base.ToString();
    }
} 

// -------------------

public class DevicesTest
{
    public static void Main()
    {
        const int SIZE = 1000;
        Device[] devices = new Device[SIZE];
        char option;
        int amount = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("What device do you want to register?");
            Console.WriteLine("1. Smartphone");
            Console.WriteLine("2. Tablet");
            Console.WriteLine("3. Computer");
            Console.WriteLine("4. Show all data");
            Console.WriteLine("5. Exit"); 
            option = Convert.ToChar(Console.ReadLine());
            
            switch (option)
            {         
                case '1':
                    // Note: this repetitive fragment should be
                    // taken to a function
                    Console.Write("Enter the speed of the device: ");
                    float newSpeed = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter the size of the screen: ");
                    float newSize = Convert.ToSingle(Console.ReadLine());
                    devices[amount] = new Smartphone(newSpeed, newSize);
                    amount++;
                    break;

                case '2':
                    Console.Write("Enter the speed of the device: ");
                    float newSpeedT = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter the size of the screen: ");
                    float newSizeT = Convert.ToSingle(Console.ReadLine());
                    devices[amount] = new Tablet(newSpeedT, newSizeT);
                    amount++;
                    break;

                case '3':
                    Console.Write("Enter the speed of the device: ");
                    float newSpeedC = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter the size of the screen: ");
                    float newSizeC = Convert.ToSingle(Console.ReadLine());
                    devices[amount] = new Computer(newSpeedC, newSizeC);
                    amount++;
                    break;

                case '4':
                    if (amount > 0)
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            Console.WriteLine(devices[i].ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No devices registered");
                    }   
                     
                    break;

                case '5':
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }  
        }
        while (option != '5');
        Console.WriteLine("Bye!");      
    }
}  
