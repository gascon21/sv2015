namespace FourInARow2016
{
    class FourInARow
    {
        public static void Main()
        {
            WelcomeScreen myWelComeScreen = new WelcomeScreen();
            int option;
            int level;

            do
            {
                option = myWelComeScreen.Display();
                if (option == 1)
                {
                    Game myGame = new Game();
                    myGame.Run();
                }
                else if (option == 2)
                {
                    WelcomeScreenIA myIA = new WelcomeScreenIA();
                    level = myIA.Display();
                    if (level == 1)
                    {
                        //TODO: vs Easy Computer Game
                        option = 0;
                    }
                    else if (level == 2)
                    {
                        //TODO: vs Average Computer Game
                        option = 0;
                    }
                    else if (level == 3)
                    {
                        //TODO: vs "The Thinker"
                        option = 0;
                    }
                    else if (level == 3)
                    {
                        option = 0;
                    }
                }
                else if (option == 3)
                {
                    CreditsScreen credits = new CreditsScreen();
                    credits.Display();
                }
            }
            while (option != 4);
        }
    }
}
