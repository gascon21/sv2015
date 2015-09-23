/* Chen Chao
* Program: maths
* Write a C# program to print on screen the result of (a+b)(a-b) 
* and a2-b2 for two numbers a,b entered by the user.
* Note: you must not use "using System;"
* 23-09-2015 */

public class Maths
{
    public static void Main()
    {
        int a, b;
        
        System.Console.WriteLine("Enter the first number");
        a = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter the second number");
        b = System.Convert.ToInt32(System.Console.ReadLine());
        
        System.Console.WriteLine("({0} + {1}) * ({0} - {1}) = {2}",
            a, b, (a + b) * (a - b));
        System.Console.WriteLine("{0}² - {1}² = {2}",a, b, a * a - b * b);
    }
}
