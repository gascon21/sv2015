/* Un garaje cobra 2,20 euros por cada hora de aparcamiento. Crea un programa 
 * que pida la hora de entrada (como un número de 4 cifras: 1000 para las 10:00) 
 * y la hora de salida (1350 para la 1.50 de la tarde), y muestre el importe a 
 * pagar, en dos supuestos distintos:

- Si cada hora o fracción se cobra completa (de 1000 a 1105 se cobrarían dos 
* horas).

- Si se paga por minutos (de 1000 a 1105 se cobrarían 65 minutos).

El programa se debe repetir hasta que el usuario introduzca "fin" como hora 
* inicial. Ten presente que desde las 1000 hasta las 1100 no hay 100 minutos, 
* sino 60 (te puede interesar descomponer esas cifras en dos, usando los 
* operadores / y %). */

using System;

public class Parking
{
    public static void Main()
    {
        float precio = 2.20f;
        float pagoHoras;
        float pagoMinutos;
        int horaEntrada, horaSalida;
        int horas, minutos;
        string texto;
        bool fin = false;
        
        do
        {
            Console.WriteLine("Introduzca las horas como un número de 4 cifras."+
                            " Por ejemplo, las 10:15 sería 1015");
            Console.Write("¿Hora de entrada? ");
            texto = Console.ReadLine();
            
            if (texto == "fin")
                fin = true;
            else
            {
                horaEntrada = Convert.ToInt32(texto);
                
                Console.Write("¿Hora de salida? ");
                horaSalida = Convert.ToInt32(Console.ReadLine());
                
                if (horaSalida < horaEntrada)
                    horaSalida += 2400;
                
                horas = horaSalida/100 - horaEntrada/100;
                minutos = horaSalida%100 - horaEntrada%100;

                //Pago por horas
                if (minutos > 0)
                    pagoHoras = (horas + 1) * precio;
                else 
                    pagoHoras = horas * precio;
                Console.WriteLine("El precio a pagar por horas es de {0} €", 
                                pagoHoras.ToString("0.00"));
                
                // Pago por minutos
                minutos += horas*60;                
                pagoMinutos = minutos * precio/60.0f;
                
                Console.WriteLine("El precio a pagar por minutos es de {0} €",
                                pagoMinutos.ToString("0.00"));
            }
            
            Console.WriteLine();
            
        } while (!fin);
        
        Console.WriteLine("Gracias por su visita.");
    }
}

