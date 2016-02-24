// WASD to move and Z to undo last movement
// Carla Liarte Felipe
// 15-2-16

using System;
using System.Collections;

public class WASD
{
    public static void Main()
    {
        int width, height;
        do
        {
            Console.WriteLine("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            
            if ((width < 2) || (height < 2))
            {
                Console.Write("Error : Cant be less two");
            }
        }
        while ((width < 2) || (height < 2));
        
        string caract;
        int moveX = 0;
        int moveY = 0;
        Stack myStack = new Stack();
        
        do
        {
            Console.WriteLine("Enter W, A, S, D or Z");
            caract = Console.ReadLine();
            caract = caract.ToUpper();
            
            if (caract != "") 
            {
                if (caract == "Z") // Do
                {
                    string undoCaracter = (string) myStack.Pop();
                    switch(undoCaracter) {
                        case "W":
                            moveY++;
                            break;
                        case "S":
                            moveY--;
                            break;
                        case "D":
                            moveX--;
                            break;
                        case "A":
                            moveX++;
                            break;
                    }
                }
                else // Undo
                {
                    myStack.Push(caract);
                    switch(caract) {
                        case "W":
                            moveY--;
                            break;
                        case "S":
                            moveY++;
                            break;
                        case "D":
                            moveX++;
                            break;
                        case "A":
                            moveX--;
                            break;
                    }
                }
            
                // Check out of range
                if (moveX >= width) 
                {
                    moveX = width - 1;
                }
                if (moveX < 0) 
                {
                    moveX = 0;
                }
                if (moveY >= height) 
                {
                    moveY = height - 1;
                }
                if (moveY < 0) 
                {
                    moveY = 0;
                }
                Console.WriteLine("{0}, {1} ", moveX, moveY);
            }
            
        }
        while (caract != "");
        
        Console.WriteLine("{0}, {1} ", moveX, moveY);
    }
}
