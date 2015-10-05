// Indra Lopez Galvez
// My second for

using System;
public class AsterisksFor {
    public static void Main() {

        Console.WriteLine("How many asteriks do you want: ");
        int asts =Convert.ToInt32(Console.ReadLine());

        for(int j = 1; j <= asts; j ++){
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
