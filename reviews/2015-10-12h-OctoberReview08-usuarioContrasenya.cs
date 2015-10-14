// Ruben Blanco
// Program: User and password

// Crea un programa que pida al usuario su identificador y su contraseña (ambos 
// numéricos), y no le permita seguir hasta que introduzca como identificador 
// "1234" y como contraseña "1111". Utiliza "do-while".


using System;

public class RubenT2Review08
{
    public static void Main()
    {
        int user, password;
        
        do
        {   
            Console.Write("Enter user: ");
            user = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter password: ");
            password = Convert.ToInt32(Console.ReadLine());
        
            if ((user != 1234) || (password != 1111))
                Console.WriteLine("Password rejected!");
        }
        while ((user != 1234) || (password != 1111));
        Console.WriteLine("Password accepted!");
    }
}
