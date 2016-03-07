// Bowling
// Indra Lopez Galvez, David Gascon Lopez, Vicente Cuenca - Corrections by Nacho

/*
Entrada de ejemplo
4 2
4 4
3 1
0 0

Salida de ejemplo
4
9
0
*/

using System;
using System.Collections;

public class ExerciseBolos
{
    public static void Main ()
     {
        string line;
        int lineas;

        do
        {
            line = Console.ReadLine();
            string[] elements = line.Split(' ');
            lineas = Convert.ToInt32(elements[0]);
            int golpeada = Convert.ToInt32(elements[1]);
            int bolosTirados = 0, bolosTotales = 0;
            
            if (lineas != 0) {
                int tiradas = lineas - golpeada + 1;
                
                for( int j = lineas; j > 0; j--) {
                    bolosTotales += j;
                }
                for( int k = tiradas; k > 0; k--) {
                    bolosTirados += k;
                }
                int restantes = bolosTotales-bolosTirados;
                Console.WriteLine(restantes);
            }
            
        } while (lineas != 0);
        
    }
}
