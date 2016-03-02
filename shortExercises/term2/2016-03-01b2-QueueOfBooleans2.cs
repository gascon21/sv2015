// Queue of booleans

using System;
using System.Collections.Generic;

public class QueueOfBooleans
{
    public static void Main()
    {
        string data=Console.ReadLine();
        Queue<bool> myQueue = new Queue<bool>();
        do
        {
            data=Console.ReadLine().ToUpper();
            if (data == "T")
                myQueue.Enqueue(true);
            else if (data == "F")
                myQueue.Enqueue(false);
        }
        while (data != "");
        
        int amountOfFalses = 0;
        while( myQueue.Count > 0 )
        {
            bool d = myQueue.Dequeue();
            if( ! d )
                amountOfFalses++;
        }
        Console.WriteLine("{0} are false", amountOfFalses);
    }
}
