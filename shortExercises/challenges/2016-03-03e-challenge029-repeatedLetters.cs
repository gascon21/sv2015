// Challenge 039: Repeated letters
// Jose Vicente y Victor Carretero, corrections by Nacho

/*
Ejemplo de entrada
3
2
AArbol
PARRA
El aarbol de la parra noooo esttaaa maaduurroo
0
El perro de san roque no tiene rabo
1
LOO
Loo es mmMuy grande

Ejemplo de salida
El aarbol de la parra no esta maduro
El pero de san roque no tiene rabo
Loo es mMuy grande
*/

using System;

public class Challenger29
{
    public static void Main()
    {
        
        
        int  casos = Convert.ToInt32(Console.ReadLine());
        
        for ( int i = 0 ; i < casos; i++ )
        {
            int palabras = Convert.ToInt32(Console.ReadLine());
            string[] dic = new string[palabras];
            for ( int j = 0 ; j <palabras ; j++)
            {
                dic[j]= Console.ReadLine();
            }
            string frase = Console.ReadLine();
            string[] trozos = frase.Split(' ');
            bool encontrado = false;
            for ( int k = 0 ; k < trozos.Length ; k++)
            {
                // Primero buscamos si es una palabra especial
                encontrado = false;
                for ( int m = 0 ; m < dic.Length;m++)
                {
                    if ( dic[m].ToUpper() == trozos[k].ToUpper() )
                        encontrado = true;
                }
                // Si no es una palabra especial, hay que eliminar repeticiones
                if (! encontrado)
                {
                    string palabra = trozos[k];
                    for (int vocal = 1;vocal < palabra.Length;vocal++)
                    {
                        if (palabra[vocal] == palabra[vocal-1])
                        {
                            palabra = palabra.Remove(vocal,1);
                            vocal--;
                        }
                    }
                    trozos[k] = palabra;
                }
            }
            Console.WriteLine( String.Join(" ", trozos) );
        }
    }
}
