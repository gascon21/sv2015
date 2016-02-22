// Stack of integers using Generics
// Chen Chao
// 17-02-2016

using System;
using System.IO;
using System.Collections;

public class Stack<T>
{
    private ArrayList list = new ArrayList();
    
    public void Push(T obj)
    {
        list.Add(obj);
    }
    
    public T Pop()
    {
        T n = (T) this.Seek();
        list.RemoveAt(list.Count - 1);
        return n;
    }
    
    public T Seek()
    {
        return (T)list[list.Count - 1];
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
        Stack<int> myStack = new Stack<int>();
        
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
