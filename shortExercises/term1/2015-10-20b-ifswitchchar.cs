/* Sergio Martínez Mira
 * if + switch, char
 * */

using System;

public class IfSwitchChar
{
    public static void Main()
    {
    
        char c;
        
        Console.WriteLine("Introduce un simbolo: ");
        
        c = Convert.ToChar(Console.ReadLine());
        
        if ((c == '-') || (c == '+') || (c == '*') || (c == '/') || (c == '%'))
            Console.WriteLine("Operador matemático.");
            
        else if ((c == '.') || (c == ',') || (c == ';'))
                Console.WriteLine("Simbolo de puntuación.");
                
        else if ((c >= '0') && (c <= '9'))
                Console.WriteLine("Cifra.");
        else 
            Console.WriteLine("Otro símbolo.");
            
        switch (c)
        {
            case '-': 
            case '+':
            case '*':
            case '/':
            case '%': 
                Console.WriteLine("Operador matemático."); 
                break;
            case ',':
            case '.':
            case ';': 
                Console.WriteLine("Simbolo de puntuación."); 
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': 
                Console.WriteLine("Cifra."); 
                break;
            default: 
                Console.WriteLine("Otro símbolo."); 
                break;
        }
    }
}
