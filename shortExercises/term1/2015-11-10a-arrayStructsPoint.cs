// Cristian Navarrete Moreno

/*
Create an "Array of points", and a menu, in which the user can choose to:

Add data for one point
Display all the entered points
Calculate (and display) the average values for x and y
Exit the program
*/

using System;
public class ArrayOfStructs
{
    struct points
    {
        public float x;
        public float y;
    }
    
    public static void Main()
    {
        const int SIZE = 100000;
        points[] point = new points [SIZE];
        byte option;
        uint totalpoints = 0;
        
        do
        {
            Console.WriteLine("1. Add data");
            Console.WriteLine("2. Display entered points");
            Console.WriteLine("3.Calculate average");
            Console.WriteLine("0. Exit");
            option = Convert.ToByte(Console.ReadLine() );
            Console.Clear();
            
            switch (option)
            {
                case 0:
                    break;
                    
                case 1: 
                    Console.WriteLine("Enter the x");
                    point[totalpoints].x = Convert.ToSingle(Console.ReadLine() );
                    Console.WriteLine("Enter the y");
                    point[totalpoints].y = Convert.ToSingle(Console.ReadLine() );
                    totalpoints++;
                    Console.WriteLine();
                    break;
                    
                case 2:
                    for(uint i = 0; i < totalpoints; i++)
                    {
                        Console.Write("Point {0} = ", i+1);
                        Console.WriteLine("({0} , {1})", point[i].x, point[i].y);
                    }
                    break;
                    
                case 3: 
                    float sumX = 0;
                    float sumY = 0;                
                    for(uint i = 0; i < totalpoints; i++)
                    {
                        sumX += point[i].x;
                        sumY += point[i].y;
                    }
                    Console.WriteLine("Average x = {0}", sumX/totalpoints);
                    Console.WriteLine("Average y = {0}", sumY/totalpoints);
                    Console.WriteLine();
                    break;
            }
        }
            while (option != 0);
                
    }
}
