// Queue of booleans, using "foreach"

using System;
using System.Collections;

public class QueueOfBooleans
{
    public static void Main()
    {
        string data=Console.ReadLine();
        Queue myQueue = new Queue();
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
        foreach( bool d in myQueue )
        {
            if( ! d )
                amountOfFalses++;
        }
        Console.WriteLine("{0} are false", amountOfFalses);
    }
}
