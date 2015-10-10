// Mónica Esteve Fernández
// Division and modulus of two numbers 

public class SeptemberReview2
{
    public static void Main()
    {
        int n1, n2;
        
        System.Console.Write("Enter the first number to divide: ");
        n1= System.Convert.ToInt32(System.Console.ReadLine());
        
        System.Console.Write("Enter the second number to divide: ");
        n2= System.Convert.ToInt32(System.Console.ReadLine());
        
        while (n2 ==0 )
        {
            System.Console.Write("The second number can't be zero, try again:");
            System.Console.Write("Enter the second number to divide: ");
            n2= System.Convert.ToInt32(System.Console.ReadLine());
        }
        
        System.Console.WriteLine("The result of {0} / {1} = {2}",n1,n2,n1/n2);
        System.Console.WriteLine("The result of {0} % {1} = {2}",n1,n2,n1%n2);
    }
}
