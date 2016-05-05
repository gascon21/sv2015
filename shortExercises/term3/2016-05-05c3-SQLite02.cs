// Creacion de tabla e insercion de datos con SQLite
using System;
using System.Data.SQLite;

class StartingSQL
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creando la base de datos...");
        // Creamos la conexion a la BD.
        // El Data Source contiene la ruta del archivo de la BD
        SQLiteConnection conexion =
            new SQLiteConnection("Data Source=ejemplo2.sqlite;Version=3;New=True;Compress=True;");
        conexion.Open();

        // Creamos la tabla
        string creacion = "create table if not exists personas ("
            + " nombre varchar(20) primary key,direccion varchar(40),edad int);";
        SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
        cmd.ExecuteNonQuery();
        //SQLiteCommand cmd;

        // E insertamos dos datos
        string insercion = "replace into personas values ('juan', 'su casa',25);";
        cmd = new SQLiteCommand(insercion, conexion);
        int cantidad = cmd.ExecuteNonQuery();
        if (cantidad < 1)
            Console.WriteLine("No se ha podido insertar");

        insercion = "replace into personas (nombre, direccion, edad)"
            + " values ('pedro', 'su calle', 23);";
        cmd = new SQLiteCommand(insercion, conexion);
        cantidad = cmd.ExecuteNonQuery();
        if (cantidad < 1)
            Console.WriteLine("No se ha podido insertar");
        
        // Finalmente, cerramos la conexion
        conexion.Close();

        Console.WriteLine("Base de datos creada.");
    }
}
