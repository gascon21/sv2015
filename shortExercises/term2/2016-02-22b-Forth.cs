// David Gascón López
// Forth

using System;
using System.Collections;

public class Forth
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("Mini Forth 0.01");
        Console.WriteLine();
        
        
        Stack myStack = new Stack();
        
        while (true)
        {
            Console.Write("> ");
            string operation = Console.ReadLine();
            
            string[] number = operation.Split(' ');
            int n1, n2;
            
            for(int i = 0 ; i < number.Length ; i ++)
                switch(number[i])
                {
                    case "+":
                        n1 =(int) myStack.Pop();
                        n2 =(int) myStack.Pop();
                        
                        myStack.Push(n1 + n2);
                        break;
                        
                    case "-":
                        n1 =(int) myStack.Pop();
                        n2 =(int) myStack.Pop();
                        
                        myStack.Push(n1 - n2);
                        break;
                        
                    case "/":
                        n1 =(int) myStack.Pop();
                        n2 =(int) myStack.Pop();
                        
                        myStack.Push(n1 / n2);
                        break;
                        
                    case "*":
                        n1 =(int) myStack.Pop();
                        n2 =(int) myStack.Pop();
                        
                        myStack.Push(n1 * n2);
                        break;
                        
                    case "mod":
                        n1 =(int) myStack.Pop();
                        n2 =(int) myStack.Pop();
                        
                        myStack.Push(n1 % n2);
                        break;
                        
                    case ".":
                        Console.WriteLine(myStack.Pop() + " ok");
                        break;
                        
                    default:
                        myStack.Push(Convert.ToInt32(number[i]));
                        break;
                }
        }
    }
}
