/// <summary>
/// Part of DamGame (Princess of Sanvi: a game by students of
/// Multiplaftorm Applications Development at IES San Vicente)
/// 
///  GameOverScreen: screen to be shown after a game
///  @author Nacho Cabanes, Alumnos DAM IesSanVicente 2015-16
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.10  15-Apr-2016  Nacho: Key R used to return, so that game is not quitted
   0.01  03-Jan-2016  Nacho: First welcome screen, with
                      options to Play, Quit and see the Credits
 ---------------------------------------------------- */

namespace DamGame
{
    class GameOverScreen
    {
        public void Run()
        {
            Font font18 = new Font("data/Joystix.ttf", 18);
            Image player = new Image("data/player.png");

            do
            {
                Hardware.ClearScreen();
                Hardware.WriteHiddenText("Game Over! Press R to return...",
                    40, 10,
                    0xCC, 0xCC, 0xCC,
                    font18);
                Hardware.DrawHiddenImage(player, 400, 300);
                Hardware.ShowHiddenScreen();

                Hardware.Pause(50);
            }
            while (!Hardware.KeyPressed(Hardware.KEY_R) );
        }
    }
}
