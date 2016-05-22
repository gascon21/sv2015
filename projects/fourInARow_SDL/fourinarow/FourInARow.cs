/* Four in a row, SDL version


0.01  20-May-2016  Sergio Martínez, Miguel Moya, Vicente Cuenca:
                   First release
0.02  21-May-2016  Nacho
                   More standard screen dimensions.
*/

class FourInARow
{
    static void Main()
    {
        bool fullScreen = false;
        Hardware.Init(800, 600, 8, fullScreen);
        bool finished = false;

        while (!finished)
        {
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Run();

            if (welcome.GetOptionChosen() == WelcomeScreen.options.Play)
            {
                Game myGame = new Game();
                myGame.Run();
            }

            if (welcome.GetOptionChosen() == WelcomeScreen.options.Quit)
                finished = true;
        }
    }
}

