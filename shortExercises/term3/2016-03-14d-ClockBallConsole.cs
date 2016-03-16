//Adrian Navarro Garcia
using System;
using System.Threading;
namespace Fechas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            bool exit = false;
            int x = 40;
            int y = 20;
            int speedX = -1;
            int speedY = -1;
            while ( ! exit )
            {
                Console.Clear();
                DateTime hoy = DateTime.Now;

                x+= speedX;
                y+= speedY;

                if ((x > 78) || (x < 1))
                    speedX *= -1;

                if ((y > 22) || (y < 1))
                    speedY *= -1;

                // Clock
                Console.SetCursorPosition(70, 0);
                if (hoy.Second % 2 == 0)
                    Console.ForegroundColor=ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(hoy.Hour.ToString("00") + ":" 
                    + hoy.Minute.ToString("00") + ":"+ hoy.Second.ToString("00"));
               
                // Ball
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine('O');
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo K = Console.ReadKey(true);
                    if (K.Key == ConsoleKey.Escape)
                        exit = true;
                }
            }
        }
    }
}
