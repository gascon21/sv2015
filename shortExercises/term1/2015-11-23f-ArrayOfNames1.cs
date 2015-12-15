/*  María Jesús Atalaya
    array textos
*/
using System;
public class ArrayTexto
{
    public static void Main()
    {
        const int SIZE=50;
        string[] data = new string[SIZE];
        int amount = 0;
        byte opcion;
        
        do
        {
            Console.WriteLine("1.- Add a new name");
            Console.WriteLine("2.- Show all data");
            Console.WriteLine("3.- Delete a name");
            Console.WriteLine("4.- Insert a name in a certain position");
            Console.WriteLine("5.- Excharde two names");
            Console.WriteLine("6.- Search for names containing a certain"
                                +"text");
            Console.WriteLine("0.- Exit");
            opcion = Convert.ToByte(Console.ReadLine());
            
            switch (opcion)
            {
                case 0:  // Exit
                    break;
                    
                case 1:
                    Console.Write ("Add a new name {0}", amount + 1);
                    data[amount] = Console.ReadLine();
                    amount++;
                    break;
                
                case 2:
                    for (int i = 0; i < amount; i++)
                        Console.WriteLine("{0}: {1}", i+1, data[i]); 
                    break;
            }
        }
        while(opcion != 0);
        Console.WriteLine("Bye!");
    }
}
