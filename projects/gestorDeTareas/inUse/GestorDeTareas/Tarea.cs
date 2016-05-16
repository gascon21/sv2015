// Gestor de tareas
// Tarea: una tarea individual

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.01   16-05-2016  Nacho, esqueleto vacío
 0.02   16-05-2016  Chen Chao y Adrian Navarro, Primera versión funcional
 0.03   16-05-2016  Chen Chao y Adrian Navarro, Método ToString totalmente
                    funcional y método Contains implementado
*/

using System;

class Tarea
{
    public DateTime Fecha { get; set; }
    public string Hora { get; set; }
    public string Descripcion { get; set; }
    public string DuracionMin { get; set; }
    public string Categoria { get; set; }
    public byte Prioridad { get; set; }
    public bool Completado { get; set; }

    public Tarea(DateTime fecha, string descripcion, string categoria,
            byte prioridad)
    {
        this.Fecha = fecha;
        this.Descripcion = descripcion;
        this.Categoria = categoria;
        this.Prioridad = prioridad;
        this.DuracionMin = "";
        this.Hora = "";
        this.Completado = false;
    }

    public Tarea(DateTime fecha, string hora, string descripcion,
            string categoria, byte prioridad)
    {
        this.Fecha = fecha;
        this.Hora = hora;
        this.Descripcion = descripcion;
        this.Categoria = categoria;
        this.Prioridad = prioridad;
        this.DuracionMin = "";
        this.Completado = false;
    }

    public Tarea(DateTime fecha, string hora, string descripcion,
            string duracionMin, string categoria, byte prioridad)
    {
        this.Fecha = fecha;
        this.Hora = hora;
        this.Descripcion = descripcion;
        this.DuracionMin = duracionMin;
        this.Categoria = categoria;
        this.Prioridad = prioridad;
        this.Completado = false;
    }

    // Este método devuelve una cadena de texto formateado sobre la 
    // información de la tarea, devuelve, prioridad, fecha en formato
    // día-mes-año, la categoría y la descripción
    public override string ToString()
    {
        if (this.Categoria.Length <= 12)
        {
            if (this.Descripcion.Length <= 44)
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm-yyyy") + " - " +
                    this.Categoria + new string(' ',
                    12 - this.Categoria.Length) + " - " +
                    this.Descripcion;
            else
            {
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm-yyyy") + " - " +
                    this.Categoria + new string(' ',
                    12 - this.Categoria.Length) + " - " +
                    this.Descripcion.Substring(0, 44);
            }
        }
        else
        {
            if (this.Descripcion.Length <= 44)
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm-yyyy") + " - " +
                    this.Categoria.Substring(0, 12) + " - " +
                    this.Descripcion;
            else
                return "" + this.Prioridad + " - " +
                    this.Fecha.ToString("dd-mm-yyyy") + " - " +
                    this.Categoria.Substring(0, 12) + " - " +
                    this.Descripcion.Substring(0, 44);
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

    // Este método marca una tarea como completado
    public void MarcarComoCompletada()
    {
        this.Completado = true;
    }

    // Mste método recibe un numero de días a atrasar y modifica la
    // fecha al número de días introducido
    public void Retrasar(int days)
    {
        this.Fecha.AddDays(days);
    }
}
