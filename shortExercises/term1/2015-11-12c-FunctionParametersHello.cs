/*
 * Pablo Padilla Martinez
Create a program whose Main must be like this:

public static void Main()
{
    SayHello("John");
    SayGoodbye();
}

SayHello and SayGoodbye are functions that you must define and that 
will be called from inside Main. As you can see in the example. 
SayHello must accept an string as a parameter.

 */

using System;

public class greeting
{
    public static void SayHello( string s)
    {
         Console.WriteLine("Hello " + s);
    }
    
    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }
    
    public static void Main()
    {  
        SayHello("Jonh");
        SayGoodbye();
    }
}
