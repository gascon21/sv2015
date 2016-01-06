// Digital clock

using System;
using System.IO;

public class DigitalClock
{
    
    public static void ProcessAndDumpLine(string line)
    {
        int[] segmentosPorCifra =
            {6, 2, 5, 5, 4, 5, 6, 3, 7, 6};
    
        long segundos = Convert.ToInt32( line );
        long total = 0;
        
        for (int i= 0; i<=segundos; i++)
        {
            long segundoActual = i % 60;
            long minutoActual = i / 60;
            long horaActual = minutoActual / 60;
            minutoActual %= 60;
            // (Supongamos que no pasa más de un día...)
            
            string numero6cifras = 
                horaActual.ToString("00")
                + minutoActual.ToString("00")
                + segundoActual.ToString("00");
            // La siguiente línea es por si fuera necesario depurar:
            // Console.WriteLine(numero6cifras);
            for (int pos=0; pos<6; pos++)
            {
                total += segmentosPorCifra[
                    Convert.ToInt32(numero6cifras[pos])-48];
            }
        }
        Console.WriteLine(total);
    }

    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        while ((text != null) && (text.Length > 0))
        {
            ProcessAndDumpLine(text);
            text = Console.ReadLine();
        }
    }
}
