// Pedro Antonio Pérez Paterna
// Converts from nautic miles to meters
public class SeptemberReview4
{
    public static void Main()
    {
        int meters;
        System.Console.WriteLine("Enter the amount of nautic miles");
        int nm = System.Convert.ToInt32(System.Console.ReadLine());
        
        meters = nm * 1852;
        
        System.Console.WriteLine("{0} nautic miles are equal to {1} meters",
            nm,meters);
    }
}
