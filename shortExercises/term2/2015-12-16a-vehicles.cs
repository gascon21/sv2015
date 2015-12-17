// Exercise on classes: Vehicle and derived classes
// Miguel Moya Ortega

using System;

public class Vehicle
{
    protected int wheels;
    protected double weight;
    protected string color;
    protected string brand;
    protected string model;
    protected short power;
    
    
    public void Accelerate()
    {
        Console.WriteLine("Accelerating");
    }
    
    
    public void Brake ()
    {
        Console.WriteLine("Braking");
    }
    
    
    public void SetModel (string x)
    {
        model = x;
    }
    
    
    public string GetModel ()
    {
         return model;
    }
}


public class Car : Vehicle
{    
    protected int doors;
    
    public Car()
    {
        wheels = 4;
    }

}


public class Motorbike : Vehicle
{
    public Motorbike()
    {
        wheels = 2;
    }
}


public class Truck : Vehicle
{
    public void Load()
    {
        Console.WriteLine("Loading...");
    }
}


public class VehicleTest
{
    public static void Main()
    {
        Car car = new Car();
        car.Accelerate();
        car.Brake();
        
        Truck truck = new Truck();
        truck.Load();
        
        Motorbike motorbike = new Motorbike();
        motorbike.SetModel("Monster");
        Console.WriteLine( motorbike.GetModel() );
    }
}
