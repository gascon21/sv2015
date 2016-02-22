// Stack of integers using ArrayList
// Chen Chao
// 17-02-2016

using System;
using System.Collections;

public class Stack
{
    private ArrayList list;
    
    public Stack()
    {
        list = new ArrayList();
    }
    
    public void Push(int obj)
    {
        list.Add(obj);
    }
    
    public int Pop()
    {
        int n = (int) list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return n;
    }
    
    public int Peek()
    {
        return (int)list[list.Count - 1];
    }
    
    public int Count()
    {
        return list.Count;
    }
}


public class StackTest
{
    public static void Main()
    {
        Stack myStack = new Stack();
        
        for (int i = 0; i < 5; i++)
        {
            myStack.Push(i);
        }
        
        Console.WriteLine((int)myStack.Seek());
        Console.WriteLine((int)myStack.Pop());
        Console.WriteLine();
        while (myStack.Count() > 0)
            Console.WriteLine((int)myStack.Pop());
    }
}
