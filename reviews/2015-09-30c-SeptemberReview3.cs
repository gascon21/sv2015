/*  María Jesús Atalaya
    Suma tres números tecleados por usuario.
*/

public class SeptemberReview3
{
    public static void Main()
    {
        // declaro variables
        int n1, n2, n3;
        int suma;
        
        // solicito al usuario
        System.Console.WriteLine ("Introduce el primer número : ");
        n1 = System.Convert.ToInt32 (System.Console.ReadLine ());
        System.Console.WriteLine ("Introduce el segundo número : " );
        n2 = System.Convert.ToInt32 (System.Console.ReadLine());
        System.Console.WriteLine ("Introduce el tercer número : ");
        n3 = System.Convert.ToInt32 (System.Console.ReadLine ());
        
        // calculo y muestro resultados
        suma = n1+n2+n3;
        System.Console.WriteLine ("El resultado es :   ");
        System.Console.WriteLine (suma);
    }
}
