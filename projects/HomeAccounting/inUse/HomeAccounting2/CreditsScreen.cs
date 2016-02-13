/// <summary>
///  Home accounting: Class CreditsScreen (credits screen)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: Almost empty skeleton
   0.13  12-Feb-2016  Pablo and Adrian: Complete the skeleton with credits of 0.13
 ---------------------------------------------------- */
using System;
namespace HomeAccounting2
{
    class CreditsScreen
    {
        public void Show()
        {
            Console.WriteLine("                      DIRECT   Nacho Cabanes");
            Console.WriteLine("                      PRODUCER   1º DAM I.E.S San Vicente");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("                      DEVELOPERS");

            Console.WriteLine("TRANSACTION-PREDICTION                     MAIN-TEAM");
            Console.WriteLine("David Gascón                           Vicente Cuenca");
            Console.WriteLine("Jorge Montalvo                         Pedro Antonio Perez");
            Console.WriteLine("Manuel Coronado                        Jose Muñoz");

            Console.WriteLine();

            Console.WriteLine("TRADUCTION'S MOESLI");
            Console.WriteLine("Carla Liarte");
            Console.WriteLine("Monica Esteve");
            Console.WriteLine("Miguel Moya");

            Console.WriteLine();

            Console.WriteLine("TRANSACTION MADE IN CHINA");
            Console.WriteLine("Chen Chao");
            Console.WriteLine("Gonzalo García");
            Console.WriteLine("Sergio Martínez");

            Console.WriteLine();

            Console.WriteLine("CONFIG TEAM");
            Console.WriteLine("Sacha Van der Sijpe");
            Console.WriteLine("Ruben Blanco");
            Console.WriteLine("Mª Jesus Atalaya");
        }
    }
}
