// Gestor de tareas
// Tarea: una tarea individual

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.01   16-05-2016  Nacho, esqueleto vacío
 0.02   16-05-2016  Chen Chao y Adrian Navarro, Primera versión funcional
*/

using System;

class Tarea
{
    public DateTime Fecha { get; set; }
    public string Hora { get; set; }
    public string Descripcion { get; set; }
    public int DuracionMin { get; set; }
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
    }

    public Tarea(DateTime fecha, string hora, string descripcion,
            string categoria, byte prioridad)
    {
        this.Fecha = fecha;
        this.Hora = hora;
        this.Descripcion = descripcion;
        this.Categoria = categoria;
        this.Prioridad = prioridad;
    }

    public Tarea(DateTime fecha, string descripcion, int duracionMin,
            string categoria, byte prioridad)
    {
        this.Fecha = fecha;
        this.Descripcion = descripcion;
        this.DuracionMin = duracionMin;
        this.Categoria = categoria;
        this.Prioridad = prioridad;
    }

    public Tarea(DateTime fecha, string hora, string descripcion,
            int duracionMin, string categoria, byte prioridad)
    {
        this.Fecha = fecha;
        this.Hora = hora;
        this.Descripcion = descripcion;
        this.DuracionMin = duracionMin;
        this.Categoria = categoria;
        this.Prioridad = prioridad;
    }

    public override string ToString()
    {
        //if (this.Hora == "" && this.DuracionMin == 0)
        return "" + this.Fecha.ToString("dd-mm-yyyy") + " - " +
            this.Categoria + " - " + this.Descripcion;
    }

    public bool Contains(string text)
    {
        // TO DO
        return true;
    }

    public void MarcarComoCompletada()
    {
        this.Completado = true;
    }

    public void Retrasar(int days)
    {
        this.Fecha.AddDays(days);
    }
}

