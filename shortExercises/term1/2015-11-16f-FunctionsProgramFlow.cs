/*  María Jesús Atalaya
    C# Functions and program flow
*/

using System;

public class Methods
{
    public static void MyFunction()
    {
        Console.WriteLine("This is the first line in the method");
        Console.WriteLine("This is the second line in the method");
        Console.WriteLine("This is the third line in the method");
    }
 
    public static void Main()
    {
        Console.WriteLine("José Ramón");
        MyFunction();
        Console.WriteLine("is my");
        MyFunction();
        Console.WriteLine("son");
    }
}

