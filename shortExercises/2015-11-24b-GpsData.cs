/*
Create a program to ask the user for the following GPS data, store them 
in a struct and then display them: latitude, longitude, speed, 
elevation, orientation (co-latitude & azimuth)
*/
using System;

public class GpsTest
{
    struct GpsData
    {
        public double latitude;
        public double longitude;
        public double elevation;
        public double speed;
        public Orientation orientation;
    }
    
    struct Orientation
    {
        public double colatitude;
        public double azimuth;
    }
    
    public static void Main()
    {
        GpsData myData;
        
        Console.WriteLine("Enter latitude: ");
        myData.latitude = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine("Enter longitude: ");
        myData.longitude = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine("Enter elevation: ");
        myData.elevation = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine("Enter speed: ");
        myData.speed = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine("Enter co-latitude: ");
        myData.orientation.colatitude = 
            Convert.ToDouble( Console.ReadLine() );
            
        Console.WriteLine("Enter azimuth: ");
        myData.orientation.azimuth = 
            Convert.ToDouble( Console.ReadLine() );
            
        Console.WriteLine("Latitude: " + myData.latitude);
        Console.WriteLine("Longitude: " + myData.longitude);
        Console.WriteLine("Elevation: " + myData.elevation);
        Console.WriteLine("Speed: " + myData.speed);
        Console.WriteLine("Co-latitude: " + myData.orientation.colatitude);
        Console.WriteLine("Azimuth: " + myData.orientation.azimuth);
    }
}
