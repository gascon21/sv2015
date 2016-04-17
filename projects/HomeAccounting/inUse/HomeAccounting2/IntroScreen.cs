/// <summary>
///  Home accounting: Class IntroScreen (welcome screen)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.18  15-Abr-2016  Monica Esteve, Jose Vicente, corrections by Nacho: 
                          Centered texts
   0.16  19-Feb-2016  Sergio Martínez Mira, María Jesús Atalaya,
                          Gonzalo García: Added pause after the title.
   0.13  12-Feb-2016  Pablo and adrian: IntroScreen
   0.12  12-Feb-2016  Nacho: Almost empty skeleton
 ---------------------------------------------------- */

using System;

namespace HomeAccounting2
{
    class IntroScreen
    {
        public void Show()
        {
            //Title
            EnhancedConsole.WriteCenteredAt(2,'c',"##      ##  ########  ##         ######    #######   ##     ##  ########");
            EnhancedConsole.WriteCenteredAt(3,'c',"##  ##  ##  ##        ##        ##    ##  ##     ##  ###   ###  ##      ");
            EnhancedConsole.WriteCenteredAt(4,'c',"##  ##  ##  ##        ##        ##        ##     ##  #### ####  ##      ");
            EnhancedConsole.WriteCenteredAt(5,'c',"##  ##  ##  ######    ##        ##        ##     ##  ## ### ##  ######  ");
            EnhancedConsole.WriteCenteredAt(6,'c',"##  ##  ##  ##        ##        ##        ##     ##  ##     ##  ##      ");
            EnhancedConsole.WriteCenteredAt(7,'c',"##  ##  ##  ##        ##        ##    ##  ##     ##  ##     ##  ##      ");
            EnhancedConsole.WriteCenteredAt(8,'c'," ###  ###   ########  ########   ######    #######   ##     ##  ########");
            
            //Message
            EnhancedConsole.WriteCenteredAt(11, 'c', "Welcome to Home Accounting.");
            EnhancedConsole.WriteCenteredAt(12, 'b', "This program will help you manage your expenses and incomes.");
            EnhancedConsole.WriteCenteredAt(15, 'y', "Press Enter to continue.");
            Console.ReadLine();

        }
    }
}
