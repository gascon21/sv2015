/*
Write a C# program to display the result of multiplying
two numbers entered by the user
*/

public class ProductUser
{
	public static void Main()
	{
		// Let's declare variables
		int x;
		int y;
		
		// Now, let's ask the user
		x = System.Convert.ToInt32(
				System.Console.ReadLine() );
		y = System.Convert.ToInt32(
				System.Console.ReadLine() );
		
		// And finally... let's calculate
		System.Console.WriteLine(x * y);
	}
}
