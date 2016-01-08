/* Sergio Martínez Mira
 * 
 * Se denomina número reversible a aquél que al ser sumado a sí mismo 
 * tras invertir sus dígitos da como resultado un número en el que 
 * todos los dígitos son impares.
 * 
 * */

using System;

public class Reversibles
{
    public static bool isReversible(int number)
    {
        // Not valid if ends with 0
        if (number % 10 == 0)
            return false;
            
        // Otherwise, let's reverse it
        string numberStr = Convert.ToString(number);
        string reversedNumberStr = "";
        
        for(int i = numberStr.Length-1; i>=0;i--)
        {
            reversedNumberStr += numberStr[i];
        }
        
        // And sum the number and its reverse
        int sum = number + Convert.ToInt32(reversedNumberStr);
        
        // All the digits must be odd
        string sumStr = Convert.ToString(sum);
        foreach(char digit in sumStr)
            if (digit % 2 == 0)
                return false;
                
        // If no even digits were found, it is reversible
        return true;
    }
    
    
    public static void Main()
    {
        int number = 0;
        
        do
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                if (isReversible(number))
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");
            }
        }
        while (number != 0);
    }
}
