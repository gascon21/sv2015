// Gestor de tareas
// Programa principal (consola)

/*
Version    Fecha    Por, cambios
---------------------------------------
 0.01   16-05-2016  Nacho, esqueleto vacío
 0.05   16-05-2016  Ruben Blanco & Vicente Cuenca: Creacion de cuerpo 
                      principal del Gestor
 0.06   16-05-2016  Monica Esteve, Jose Vicente Leal: Mostrar texto con Scroll,
                      primera aproximación
 0.12   17-05-2016  Nacho:
                      Corregidos "do-while" incorrectos en añadir
                      Se propone la fecha actual (primer acercamiento: día)
                      Renombrada la variable "año" a "anyo"
 0.13   17-05-2016  Adrian Navarro y Victor Carretero : Metodo buscar

*/

using System;
using System.Collections.Generic;

public class GestorDeTareas
{
    enum options
    {
        SALIR, AÑADIR, MODIFICAR, RETRASAR, BUSCAR, BORRAR
    };

    public static void Main(string[] args)
    {
        ListaDeTareas tareas = new ListaDeTareas();
        tareas.Cargar();
        byte option;
        DateTime fechaMostrar = DateTime.Now;

        do
        {
            // Cargamos la Lista de Tareas
            List<string> tareasMostrar = tareas.DevuelveFecha(fechaMostrar);

            //Cabecera de la pantalla principal
            Console.WriteLine("Prio    Categoria    Fecha           Descripcion");
            Console.WriteLine("------------------------------------------------");

            //Mostramos en pantalla la lista de tareas
            for (int i = 0; i < tareasMostrar.Count; i++)
            {
                Console.WriteLine(tareasMostrar[i]);
            }

            //Lista de opciones a elegir
            Console.WriteLine("1 - Añadir Tarea");
            Console.WriteLine("2 - Modificar Tarea");
            Console.WriteLine("3 - Retrasar Tarea");
            Console.WriteLine("4 - Buscar Tarea");
            Console.WriteLine("5 - Borrar Tarea");
            Console.WriteLine("0 - Salir");
            option = Convert.ToByte(Console.ReadLine());

            switch (option)
            {
                case (int)options.AÑADIR:

                    // Variables auxiliares para rellenar en las tareas nuevas
                    string respuesta;
                    int dia = 0, mes = 0, anyo = 0;
                    string tarea = "", categoria = "";
                    byte prioridad = 0;

                    // Datos a rellenar de cada tarea
                    // Los obligatorios van blindados con do-while
                    DateTime ahora = DateTime.Now;
                    do
                    {
                        int diaPropuesto = ahora.Day;
                        Console.Write("Inserte el dia (Intro para {0}): ", diaPropuesto);
                        respuesta = Console.ReadLine();
                        if (respuesta == "")
                            dia = diaPropuesto;
                        else
                            dia = Convert.ToInt32(respuesta);
                    } while (dia == 0);

                    do
                    {
                        Console.Write("Inserte el mes: ");
                        mes = Convert.ToInt32(Console.ReadLine());
                    } while (mes == 0);

                    do
                    {
                        Console.Write("Inserte el año: ");
                        anyo = Convert.ToInt32(Console.ReadLine());
                    } while (anyo == 0);

                    DateTime fecha = new DateTime(anyo, mes, dia);

                    Console.Write("Inserte la hora (opcional): ");
                    string hora = Console.ReadLine();

                    do
                    {
                        Console.Write("Descripcion de la tarea: ");
                        tarea = Console.ReadLine();
                    } while (tarea == "");

                    Console.Write("Inserte la duracion (opcional): ");
                    string duracion = Console.ReadLine();

                    do
                    {
                        Console.Write("Categoría de la tarea: ");
                        categoria = Console.ReadLine();
                    } while (categoria == "");

                    do
                    {
                        Console.Write("Prioridad de la tarea(1-5): ");
                        prioridad = Convert.ToByte(Console.ReadLine());
                    } while ((prioridad < 1) || (prioridad > 5));

                    tareas.Anyadir(fecha, hora, tarea, duracion, categoria, prioridad);
                    bool guardadoCorrecto = tareas.Guardar();
                    if (!guardadoCorrecto)
                        Console.WriteLine("No se ha podido guardar!");
                    break;

                case (int)options.MODIFICAR:
                    //Console.Write("Que tarea debo modificar? ");
                    //string palabraMod = Console.ReadLine();

                    Console.WriteLine("Operacion no realizada: En desarrollo");
                    //TODO:
                    //miTarea.Guardar();
                    break;
                case (int)options.BUSCAR:
                    Console.Write("Que palabra clave debo buscar? ");
                    string palabraBuscar = Console.ReadLine();

                    List<string> resultados = tareas.Buscar(palabraBuscar);

                    Console.WriteLine();
                    for (int i = 0; i < resultados.Count; i++)
                    {
                        Console.WriteLine("Resultado : " + (i + 1));
                        Console.WriteLine(resultados[i]);
                        Console.WriteLine();
                    }
                    break;

                case (int)options.BORRAR:
                    //Console.Write("Que nº de tarea debo borrar? ");
                    //string numeroBorrar = Console.ReadLine();

                    Console.WriteLine("Operacion no realizada: En desarrollo");
                    //TODO:
                    //miTarea.Guardar();
                    break;

                case (int)options.SALIR:

                    Console.WriteLine("Hasta luego!");
                    break;
            }
        }
        while (option != 0);
    }

    public static void MostrarConScroll(List<string> datos)
    {

        bool exit = false;
        int y = Console.CursorTop;
        int x = Console.CursorLeft;

        do
        {   // recogemos la tecla presionada
            ConsoleKeyInfo key = Console.ReadKey();

            // bajamos
            if (key.Key == ConsoleKey.DownArrow)
                y += 1;
            //subimos
            if (key.Key == ConsoleKey.UpArrow)
                y -= 1;
            // control limite superior
            if (y < 0)
                y = 0;

            Console.SetCursorPosition(x, y);

            //salimos del scroll
            if (key.Key == ConsoleKey.Escape)
                exit = true;
        }
        while (!exit);
    }

}