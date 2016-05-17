// Gestor de tareas
// TareaRepetitiva: una tarea periódica individual

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.01   16-05-2016  Nacho, esqueleto vacío
 0.04   16-05-2016  Indra Lopez y Pedro Perez, atributos, constructor, 
                      metodos mostrarTarea, Posponer y Comprobar
 0.06   16-05-2016  Nacho, comentado "Comprobar"
*/

using System;

enum PERIODICIDAD { A, M, S, D }; // Periodicidad: A Anual | M mensual | S Semanal | D diaria 
class TareaRepetitiva
{
    public DateTime Fecha { get; set; }
    public string Hora { get; set; }
    public string Descripcion { get; set; }
    public int DuracionMin { get; set; }
    public string Categoria { get; set; }
    public byte Prioridad { get; set; }
    public bool Completada { get; set; }
    public bool visible { get; set; }
    // En esta version la periodicidad esta prefijada a anual, en el futuro 
    // implementaremos el resto de periodicidades
    private PERIODICIDAD periodicidad;

    public TareaRepetitiva(DateTime fecha, string hora,
        string descripcion, int duracionMin, string categoria, byte prioridad)
    {
        Fecha = fecha;
        Hora = hora;
        Descripcion = descripcion;
        DuracionMin = duracionMin;
        Categoria = categoria;
        Prioridad = prioridad;
        Completada = false;
        visible = true;
    }

    // Si la fecha de la tarea se corresponde con la 
    // tarea actual, la tarea seguirá siendo false ya que
    // no se habrá realizado
    public void Comprobar()
    {
        DateTime ahora = DateTime.Now;
        //if (Fecha == ahora && Completada)
        //    miTarea.MarcarComoCompletada();
    }

    // La tarea una vez se pospone, pasa a no ser visible 
    // desde la lista de tareas si la fecha de la tarea es 
    // distinta a la actual y el año de la tarea es distinto 
    // al año actual.
    public void Posponer(DateTime Fecha, int days)
    {
        DateTime ahora = DateTime.Now;
        DateTime anyo = new DateTime(ahora.Year);
        if (Fecha != ahora && Fecha.Year != anyo.Year)
        {
            visible = false;
            Fecha.AddDays(days);    // Añadimos los días a posponer la tarea
        }
    }

    // Si llega el mismo día o el mismo mes
    // que cuando pase el año, mostrar la 
    // tarea repetitiva de nuevo en la lista de tareas.
    public void MostrarTarea()
    {
        DateTime diaFuturo = DateTime.Now;
        if (Fecha.Day == diaFuturo.Day || Fecha.Month == diaFuturo.Month)
            visible = true;
    }
}
