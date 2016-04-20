// TextCensorer (using ReadToEnd)
// ADRIAN NAVARRO GARCIA

using System;
using System.IO;

class SUPERCENSURADOR__PATANEGRA
{
    static void Main(string[] args)
    {
        if (args.Length==0)
        {
            Console.WriteLine("No se han especificado parametros");
            return;
        }

        // TO DO: The definitive version must process "args"
        string filename = "censurable.txt";

        if (File.Exists(filename))
        {
            try
            {
                StreamReader fichero1 = File.OpenText(filename);
                StreamReader fichero2 = File.OpenText("censura.txt");
                StreamWriter fichero3 = File.CreateText("ficheroSalida.txt");

                int tamanyoArray = Convert.ToInt32(fichero2.ReadLine());
                string[] censura = new string[tamanyoArray];

                for (int i = 0; i < tamanyoArray; i++)
                {
                    censura[i] = fichero2.ReadLine();
                }

                string todoTexto = fichero1.ReadToEnd();

                for (int i = 0; i < tamanyoArray; i++)
                {
                    todoTexto = todoTexto.Replace(' ' + censura[i] + ' ', 
                        " [CENSORED] ");
                    todoTexto = todoTexto.Replace(' ' + censura[i] + ", ", 
                        " [CENSORED], ");
                    todoTexto = todoTexto.Replace(' ' + censura[i] + ". ", 
                        " [CENSORED]. ");
                }
                // TO DO: Start of sentence and end of sentence should
                // be censored too

                fichero3.Write(todoTexto);

                fichero1.Close();
                fichero2.Close();
                fichero3.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Ruta demasiado larga");
            }
            catch (IOException)
            {
                Console.WriteLine("No se pudo leer el fichero");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Se ha producido el error : "+exp.Message);
            }

        }
        else
            Console.WriteLine("El fichero no existe");

    }
}
