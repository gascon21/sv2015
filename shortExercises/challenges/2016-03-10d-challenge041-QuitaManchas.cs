// Cantidad de manchas

/*
Ejemplo de entrada
5 4
-----
#-#--
---#-
---#-

Ejemplo de salida
2

Ejemplo de entrada
5 4
##-##
##-##
-----
#####

Ejemplo de salida
3

Ejemplo de entrada
9 5
##-##--#-
##-##-#-#
-------#-
#####----
------#-#

Ejemplo de salida
6
*/


using System;

public class Manchas
{
    public static void Main()
    {
        string[] tamanyo = Console.ReadLine().Split(' ');
        int ancho = Convert.ToInt32( tamanyo[0] );
        int alto = Convert.ToInt32( tamanyo[1] );
        
        char[][] datos = new char[alto][];
        
        for (int fila=0; fila < alto; fila++)
        {
            string linea = Console.ReadLine();
            datos[fila] =  linea.ToCharArray();
        }
        
        bool manchaEncontrada;
        int cantidadManchas = 0;
        do
        {
            manchaEncontrada = false;
            for (int fila=0; fila < alto; fila++)
                for (int col=0; col < ancho; col++)
                {
                    if (datos[fila][col] == '#')
                    {
                        cantidadManchas ++;
                        manchaEncontrada = true;
                        BorrarMancha(datos, ancho, alto, fila, col);
                    }
                }
        }
        while (manchaEncontrada);
        Console.WriteLine(cantidadManchas);
    }
    
    public static void BorrarMancha(char [][] datos, 
        int ancho, int alto, int fila, int col)
    {
        datos[fila][col] = '-';
        
        if ((fila > 0) && (col > 0) && (datos[fila-1][col-1] == '#'))
            BorrarMancha(datos, ancho, alto, fila-1, col-1);
        if ((fila > 0) && (datos[fila-1][col] == '#'))
            BorrarMancha(datos, ancho, alto, fila-1, col);
        if ((fila > 0) && (col < ancho-1) && (datos[fila-1][col+1] == '#'))
            BorrarMancha(datos, ancho, alto, fila-1, col+1);
            
        if ((col > 0) && (datos[fila][col-1] == '#'))
            BorrarMancha(datos, ancho, alto, fila, col-1);
        if ((col < ancho-1) && (datos[fila][col+1] == '#'))
            BorrarMancha(datos, ancho, alto, fila, col+1);
        
        if ((fila < alto-1) && (col > 0) && (datos[fila+1][col-1] == '#'))
            BorrarMancha(datos, ancho, alto, fila+1, col-1);
        if ((fila < alto-1) && (datos[fila+1][col] == '#'))
            BorrarMancha(datos, ancho, alto, fila+1, col);
        if ((fila < alto-1) && (col < ancho-1) && (datos[fila+1][col+1] == '#'))
            BorrarMancha(datos, ancho, alto, fila+1, col+1);
    }
}
