//Indra Lopez Galvez
//Program to get how many digits there are in a number

using System;
public class ManyDigits{
    
    public static void Main(){
        
        int number,digits= 1;
        Console.Write("Number? ");
        number = Convert.ToInt32(Console.ReadLine());
        
        if(number < 0){
            Console.WriteLine("(Warning: it is a negative number)");
            number = number *-1;
        }
        
        while (number >= 10){
            number = number/10;
            digits++;
        }
        
        Console.WriteLine("{0} digits", digits);
    }
    
}
