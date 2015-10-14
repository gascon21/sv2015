/*  María Jesús Atalaya
    (2.2.10.1) Crea un programa que pida al usuario dos números
    y escriba su máximo común divisor (pista: una solución lenta 
    pero sencilla es probar con un "for" todos los números descendiendo
    a partir del menor de ambos, hasta llegar a 1; cuando encuentres un
    número que sea divisor de ambos, interrumpes la búsqueda con "break").
*/
using System;
public class Divisibles
{
    public static void Main()
    {
        int n1, n2;
        int menor;
        int i;
        
        Console.WriteLine ("Escribe el primer numero");
        n1=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine ("Escribe el segundo numero");
        n2=Convert.ToInt32(Console.ReadLine());
        
        if (n1<n2)
            menor=n1;
        else
            menor=n2;
            
        for (i=menor; i>=1; i--)
            if ((n1 % i == 0) && (n2 % i == 0))
                break;
                
        Console.WriteLine ("El Max. Comun Divisor es: {0} ", i);
    }
}

