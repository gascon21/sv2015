// Queue of strings

using System;

public class Queue
{
    protected string[] myQueue;
    public int Count {get; set;}
    
    public Queue()
    {
        Count = 0;
        myQueue = new string[100];
    }
    
    public void Enqueue(string text)
    {
        myQueue[Count] = text;
        Count++;
    }
    
    public string Dequeue()
    {
        string data = myQueue[0];
        for(int i=0;i<Count-1;i++)
            myQueue[i] = myQueue[i+1];
        myQueue[Count] = null;
        Count--;
        return data;
    }    
}


public class QueueTest
{
    public static void Main()
    {
        Queue myQueue = new Queue();
        
        myQueue.Enqueue("1");
        myQueue.Enqueue("2");
        
        if (myQueue.Count != 2)
            Console.WriteLine("Error in counter");
        
        if (myQueue.Dequeue() != "1")
            Console.WriteLine("Error in first data");
        
        myQueue.Enqueue("3");
        
        if (myQueue.Dequeue() != "2")
            Console.WriteLine("Error in second data");
        if (myQueue.Dequeue() != "3")
            Console.WriteLine("Error in third data");
                    
        Console.WriteLine("Finished");
    }
}


