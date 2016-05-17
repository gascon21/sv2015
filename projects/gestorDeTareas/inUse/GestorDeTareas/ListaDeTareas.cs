// Gestor de tareas
// ListaDeTareas: lista de varias tareas

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.01   16-05-2016  Nacho, esqueleto vacío
 0.10   16-05-2016  Jose Muñoz y Miguel Moya: Primeras funcionalidades
 0.11   16-05-2016  Sergio Martinez y David Gascón: Cargar y guardar
*/

using System;
using System.Collections.Generic;
using System.IO;

class ListaDeTareas
{
    private List<Tarea> _lista;


    public ListaDeTareas()
    {
        _lista = new List<Tarea>();
    }


    // Creamos 3 constructores
    // Constructor con todos los datos
    public bool Añadir(DateTime tiempo, string hora, string descripcion,
            string duracion, string categoria, byte prioridad)
    {
        try
        {
            Tarea tarea = new Tarea(tiempo, hora, descripcion, duracion,
                categoria, prioridad);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    // Constructor sin duracion
    public bool Añadir(DateTime tiempo, string hora, string descripcion,
       string categoria, byte prioridad)
    {
        try
        {
            Tarea tarea = new Tarea(tiempo, hora, descripcion,
                categoria, prioridad);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    // Constructor sin hora
    public bool Añadir(DateTime tiempo, string descripcion, string categoria,
        byte prioridad)
    {
        try
        {
            Tarea tarea = new Tarea(tiempo, descripcion, categoria, prioridad);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool Actualizar(int posicion, DateTime fecha)
    {
        try
        {
            // Creamos una tarea temporal para modificar la de la lista
            Tarea tTemp = _lista[posicion];
            tTemp.Fecha = fecha;
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool Actualizar(int posicion)
    {
        Tarea tTemp;
        return false;
    }



    public bool Borrar(int posicion)
    {
        try
        {
            _lista.RemoveAt(posicion);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }


    //public bool Retrasar()
    //{
    //    // TO DO
    //    return false;
    //}


    public bool MarcarComoCompletada(int posicion)
    {
        try
        {
            Tarea tTemp;
            tTemp = _lista[posicion];
            tTemp.MarcarComoCompletada();
            _lista[posicion] = tTemp;
            return true;
        }
        // TO DO
        catch (Exception)
        {
            return false;
        }
    }


    public Tarea Buscar(int posicion)
    {
        return _lista[posicion];
    }


    public List<string> DevuelveFecha()
    {
        List<string> lista = new List<string>();
        for (int i = 0; i < _lista.Count; i++)
            lista.Add(_lista[i].ToString());
        return lista;
    }

    public List<string> DevuelveFecha(DateTime fecha)
    {
        List<string> lista = new List<string>();
        for (int i = 0; i < _lista.Count; i++)
            if (_lista[i].Fecha == fecha)
                lista.Add(_lista[i].ToString());
        return lista;
    }


    public List<Tarea> GetTareas()
    {
        return _lista;
    }


    //The program writes in play text the data of a whole list of "Tareas"
    private static bool Save(List<Tarea> tareas)
    {
        try
        {
            StreamWriter FichSalida = File.CreateText("tareas.dat");

            for (int i = 0; i < tareas.Count; i++)
            {
                FichSalida.WriteLine(tareas[i].Fecha);
                FichSalida.WriteLine(tareas[i].Hora);
                FichSalida.WriteLine(tareas[i].Descripcion);
                FichSalida.WriteLine(tareas[i].DuracionMin);
                FichSalida.WriteLine(tareas[i].Categoria);
                FichSalida.WriteLine(tareas[i].Prioridad);
                FichSalida.WriteLine(tareas[i].Completado);
            }

            FichSalida.Close();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    //The program reads from the text file and using a temp "Tarea" object will load a list of "Tareas"
    public bool Load()
    {
        if (File.Exists("tareas.dat"))
        {
            try
            {
                Tarea tareaTemp;
                string linea;
                StreamReader FichEntrada = File.OpenText("tareas.dat");

                do
                {
                    linea = FichEntrada.ReadLine();
                    if (linea != null)
                    {
                        tareaTemp = new Tarea(Convert.ToDateTime(FichEntrada.ReadLine()),
                            FichEntrada.ReadLine(), FichEntrada.ReadLine(), FichEntrada.ReadLine(),
                                 FichEntrada.ReadLine(), Convert.ToByte(FichEntrada.ReadLine()));
                        //Loads the data on the tempTarea and then adds it to the list
                        //tareaTemp.Fecha = Convert.ToDateTime(FichEntrada.ReadLine());
                        //tareaTemp.Hora = FichEntrada.ReadLine();
                        //tareaTemp.Descripcion = FichEntrada.ReadLine();
                        //tareaTemp.DuracionMin = FichEntrada.ReadLine();
                        ////tareaTemp.Categoria = FichEntrada.ReadLine();
                        //tareaTemp.Prioridad = Convert.ToByte(FichEntrada.ReadLine());
                        tareaTemp.Completado = Convert.ToBoolean(FichEntrada.ReadLine());
                        //tareaTemp.Completado = Convert.ToBoolean(FichEntrada.ReadLine());

                        _lista.Add(tareaTemp);
                    }
                }
                while (linea != null);

                FichEntrada.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
            
        }
        return false; // Si no existe
    }
}