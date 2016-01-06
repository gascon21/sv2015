// Chen Chao
// 01-01-2016

using System;

public class Ejer06NavBasic
{
    struct Car
    {
        public string brand;
        public string model;
        public double power;
    }
    
    
    public static void Main()
    {
        const byte SIZE = 5;
        Car[] car = new Car[SIZE];
        
        for (byte i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the brand of the car{0}: ", i+1);
            car[i].brand = Console.ReadLine();
            Console.Write("Enter the model of the car{0}: ", i+1);
            car[i].model = Console.ReadLine();
            Console.Write("Enter the power of the car{0}: ", i+1);
            car[i].power = Convert.ToDouble(Console.ReadLine());
        }
        
        double maxPower = car[0].power;
        
        for (byte i = 0; i < SIZE; i++)
            maxPower = maxPower > car[i].power ? maxPower : car[i].power;
        
        for (byte i = 0; i < SIZE; i++)
            if (maxPower == car[i].power)
                Console.WriteLine("The most powerful car is {0}-{1}-{2}",
                    car[i].brand, car[i].model, car[i].power);
    }
}
