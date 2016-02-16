// Stack of integers

using System;
using System.Collections;

class IntStack
{
    public static void Main()
    {
        Stack s = new Stack();
        int number;
        do
        {
            Console.Write("Number?");
            number = Convert.ToInt32(Console.ReadLine());
            if(number != 0)
                s.Push(number);
        }
        while(number != 0);
        
        while(s.Count > 0)        
        {
            int n = (int) s.Pop();
            Console.Write(n+" ");
        }
        Console.WriteLine();
    }
}
