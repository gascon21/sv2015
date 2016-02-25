using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        bool error = false;
        Stack stack = new Stack();
        Console.Write("Operation: ");
        string operation = Console.ReadLine();

        for (int i = 0; i < operation.Length && !error; i++)
        {
            if (operation[i] == '(')
                stack.Push('(');
            else if (operation[i] == ')')
            {
                if (stack.Count > 0)
                    stack.Pop();
                else
                {
                    error = true;
                }
            }
        }

        if (stack.Count != 0)
            error = true;

        if (error == true)
            Console.WriteLine("ERROR");
        else
            Console.WriteLine("OK");
    }
}
