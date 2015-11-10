// Name: Jose Vicente Leal 
// Program:  Challenge007

/*

Nochevieja

Ramón se pasa el día de Nochevieja contando los minutos que faltan para 
que den las uvas. ¿Puedes ayudarle?

Entrada

La entrada consiste en una serie de horas, cada una en una línea. Cada 
hora está formada por las horas y los minutos separados por : y 
utilizando siempre dos dígitos. Se utiliza una representación en 
formato 24 horas (es decir, desde 00:00 a 23:59).

La entrada termina cuando la hora es la medianoche (00:00), que no debe 
procesarse.

Salida

Para cada caso de prueba se mostrará una línea con el número de minutos 
que faltan para medianoche.

Entrada de ejemplo
23:45
21:30
00:01
00:00

Salida de ejemplo
15
150
1439

Source: https://www.aceptaelreto.com/problem/statement.php?id=148

*/

using System;
public class Challenge007
{
    public static void Main()
    {
        const int MINUTESDAY = 24*60;
        string time;
        do
        {
            time = Console.ReadLine();
            
            if (time != "00:00")
            {
                int hours=0;
                int minutes=0;
                int totalminutes=0;
                
                string[] words = time.Split(':');
                
                hours = Convert.ToInt32(words[0]);
                minutes = Convert.ToInt32(words[1]);
                
                totalminutes = hours * 60 + minutes;
                    
                Console.WriteLine(MINUTESDAY - totalminutes);
            }
        }while (time != "00:00");
    } 
}
