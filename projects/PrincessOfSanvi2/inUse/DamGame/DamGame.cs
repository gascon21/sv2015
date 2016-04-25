/// <summary>
/// Part of DamGame (Princess of Sanvi: a game by students of
/// Multiplaftorm Applications Development at IES San Vicente)
/// 
///  DamGame: Launch welcome, credits, game and so on
///  @author Nacho Cabanes, Alumnos DAM IesSanVicente 2015-16
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.01  03-Jan-2016  Nacho: First version to launch welcome, credits, game and so on
 ---------------------------------------------------- */

namespace DamGame
{
    class DamGame
    {
        static void Main(string[] args)
        {
            bool fullScreen = false;
            Hardware.Init(1024,768, 24, fullScreen);
            bool finished = false;

            while (!finished)
            {
                WelcomeScreen welcome = new WelcomeScreen();
                welcome.Run();

                if (welcome.GetOptionChosen() == WelcomeScreen.options.Credits)
                {
                    CreditsScreen credits = new CreditsScreen();
                    credits.Run();
                }

                if (welcome.GetOptionChosen() == WelcomeScreen.options.Play)
                {
                    Game myGame = new Game();
                    myGame.Run();

                    GameOverScreen gameEnd = new GameOverScreen();
                    gameEnd.Run();
                }

                if (welcome.GetOptionChosen() == WelcomeScreen.options.Quit)
                    finished = true;
            }
        }
    }
}
