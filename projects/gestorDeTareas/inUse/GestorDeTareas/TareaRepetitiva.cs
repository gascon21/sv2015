// Gestor de tareas
// TareaRepetitiva: una tarea periódica individual

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.01   16-05-2016  Nacho, esqueleto vacío
 0.04   16-05-2016  Indra Lopez y Pedro Perez, atributos, constructor, 
                      metodos mostrarTarea, Posponer y Comprobar
 0.06   16-05-2016  Nacho, comentado "Comprobar"
 0.14   17-05-2016  Chen Chao y Pedro Antonio, mejora de constructores,
                    modificación de métodos mostrarTarea a ToString,
                    posponer a retrasar, comprobar eliminado y añadido
                    el método contains, eliminado propiedades completada y
                    visible, la propiedad duracionMin cambiado de int a
                    string, modificado constructores, ahora reciben
                    la periodicidad excepto uno que se prefija a anual
*/

using System;

// Periodicidad: A Anual | M mensual | S Semanal | D diaria
enum PERIODICIDAD { A, M, S, D }; 

class TareaRepetitiva
{
    public DateTime Fecha { get; set; }
    public string Hora { get; set; }
    public string Descripcion { get; set; }
    public string DuracionMin { get; set; }
    public string Categoria { get; set; }
    public byte Prioridad { get; set; }

    // En esta version la periodicidad esta prefijada a anual, en el futuro 
    // implementaremos el resto de periodicidades
    private PERIODICIDAD periodicidad;

    public TareaRepetitiva(DateTime fecha, string hora,
        string descripcion, string duracionMin, string categoria,
        byte prioridad)
    {
        Fecha = fecha;
        Hora = hora;
        Descripcion = descripcion;
        DuracionMin = duracionMin;
        Categoria = categoria;
        Prioridad = prioridad;
        this.periodicidad = PERIODICIDAD.A;
    }

    public TareaRepetitiva(DateTime fecha, string hora,
        string descripcion, string duracionMin, string categoria,
        byte prioridad, char periodicidad)
    {
        Fecha = fecha;
        Hora = hora;
        Descripcion = descripcion;
        DuracionMin = duracionMin;
        Categoria = categoria;
        Prioridad = prioridad;
        this.periodicidad = periodicidad == 'A' ? PERIODICIDAD.A :
            periodicidad == 'M' ? PERIODICIDAD.M : periodicidad == 'S' ?
            PERIODICIDAD.S : PERIODICIDAD.D;
    }

    public TareaRepetitiva(DateTime fecha, string descripcion, 
            string duracionMin, string categoria, byte prioridad,
            char periodicidad)
    {
        Fecha = fecha;
        Hora = "";
        Descripcion = descripcion;
        DuracionMin = duracionMin;
        Categoria = categoria;
        Prioridad = prioridad;
        this.periodicidad = periodicidad == 'A' ? PERIODICIDAD.A :
            periodicidad == 'M' ? PERIODICIDAD.M : periodicidad == 'S' ?
            PERIODICIDAD.S : PERIODICIDAD.D;
    }

    public TareaRepetitiva(DateTime fecha, string descripcion, 
            string categoria, byte prioridad, char periodicidad)
    {
        Fecha = fecha;
        Hora = "";
        Descripcion = descripcion;
        DuracionMin = "";
        Categoria = categoria;
        Prioridad = prioridad;
        this.periodicidad = periodicidad == 'A' ? PERIODICIDAD.A :
            periodicidad == 'M' ? PERIODICIDAD.M : periodicidad == 'S' ?
            PERIODICIDAD.S : PERIODICIDAD.D;
    }

    // La tarea una vez se pospone, pasa a no ser visible 
    // desde la lista de tareas si la fecha de la tarea es 
    // distinta a la actual y el año de la tarea es distinto 
    // al año actual.
    public void Retrasar(int days)
    {
        this.Fecha.AddDays(days);
    }

    // Si llega el mismo día o el mismo mes
    // que cuando pase el año, mostrar la 
    // tarea repetitiva de nuevo en la lista de tareas.
    // Este método devuelve una cadena de texto formateado sobre la 
    // información de la tarea, devuelve, prioridad, fecha en formato
    // día-mes-año, la categoría y la descripción
    public override string ToString()
    {
        if (this.Categoria.Length <= 12)
        {
            if (this.Descripcion.Length <= 49)
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm") + " - " +
                    this.Categoria + new string(' ',
                    12 - this.Categoria.Length) + " - " +
                    this.Descripcion;
            else
            {
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm") + " - " +
                    this.Categoria + new string(' ',
                    12 - this.Categoria.Length) + " - " +
                    this.Descripcion.Substring(0, 49);
            }
        }
        else
        {
            if (this.Descripcion.Length <= 49)
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm") + " - " +
                    this.Categoria.Substring(0, 12) + " - " +
                    this.Descripcion;
            else
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm") + " - " +
                    this.Categoria.Substring(0, 12) + " - " +
                    this.Descripcion.Substring(0, 49);
        }
    }

    // Este método recibe como parámetro un texto a buscar en la
    // descripción de la tarea sin importar mayúsculas ni minúsculas,
    // y devuelve verdadero si se encuentra el texto, falso si no lo 
    // encuentra.
    public bool Contains(string text)
    {
        return this.Descripcion.ToLower().Contains(text.ToLower());
    }
}
