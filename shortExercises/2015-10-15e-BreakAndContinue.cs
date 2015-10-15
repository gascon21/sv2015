// Jorge Montalvo Blanes
// Break and continue

/*
Create a program to write the even numbers from 10 to 20, both 
included, except 16, in 3 different ways:

- Incrementing 2 in each step (use "continue" to skip 16)

- Incrementing 1 in each step (use "continue")

- With and endless loop (using "break" & "continue")
*/

using System;

public class BreakAndContinue
{
    public static void Main()
    {
        // Incrementing 2 in each step
        for(int number = 10;number<=20;number+=2)
        {
            if(number == 16)continue;
            Console.Write("{0} ",number);
        }
        Console.WriteLine();
        
        // Incrementing 1 in each step
        for(int number = 10;number <= 20;number++)
        {
            if(number%2!=0)continue;
            if(number == 16)continue;
            Console.Write("{0} ",number);
        }
        Console.WriteLine();
        
        // With an endless loop
        for(int number = 10; /* --- */ ;number+=2)
        {
            if(number == 16)continue;
            
            Console.Write("{0} ",number);
            
            if(number == 20)break;
        }
        Console.WriteLine();
        
        // Alternate... a true endless loop
        int n = 10;
        while(n<=20)
        {
            if(n == 16)continue;
            Console.Write("{0} ",n);
            n+=2;
        }
        Console.WriteLine();
    }
}
