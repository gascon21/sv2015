using System;
public class hexadecimalTable
{
    public static void Main()
    {
        for (byte fila = 0; fila < 16; fila++)
        {
            Console.Write(fila*16 +": ");
            for (byte colum = 0; colum < 16; colum++)
            {
                if (fila == 0)
                    Console.Write ("0");
                Console.Write(Convert.ToString(fila*16+colum, 16)+ " ");
            }
            Console.WriteLine();
        }
        
    }
}
