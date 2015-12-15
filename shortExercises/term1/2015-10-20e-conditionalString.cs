/*
 *José Miguel Leonis 
 * 
 * Calificaciones con string
 */

using System;
public class ej72
{
    public static void Main()
    {
        string calificacion;
        int nota;
        
        Console.WriteLine("Introduce la nota: ");
        nota =Convert.ToInt32(Console.ReadLine());
        
        if (nota > 7)
            calificacion = "Excelente";
        else if (nota >= 5)
            calificacion = "Aprobado";
        else
            calificacion = "Suspenso";
            
        calificacion = nota > 7 ? "Excelente":
            nota >= 5 ? "Aprobado" : "Suspenso";
            
        Console.WriteLine(calificacion);
    }
}
