// Jose Muñoz
// Function with two parameters

using System;
public class FunctionWithTwoParameters
{
    public static void SayHello( string n1, string n2)
    {
        Console.WriteLine("Hello! " + n1 + " and " + n2 + "!");
    }
    
    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }
    
    public static void Main()
    {
        SayHello("John", "Peter");
        SayGoodbye();
    }
}
