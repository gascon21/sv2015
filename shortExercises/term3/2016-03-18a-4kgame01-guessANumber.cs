// Manuel Coronado Cuevas
// 4k game: Guess A Number (Removed spaces)
// Minor corrections by Nacho:
// - 0 to 1000, 10 attempts
// - Inform if attempt is higher or lower

using System;
class GuessANumber
{
static void Main(string[] args)
{
Random random = new Random();
int randomNumber = random.Next(0, 1001);
int numberTry;
int win = 1;
int attempts = 10;
do
{
Console.Write("Enter a number (1 to 1000): ");
numberTry = Convert.ToInt32(Console.ReadLine());
if(numberTry == randomNumber) win = 0;
else
{
Console.Write("Oh! You've failed! ");
if (numberTry > randomNumber) 
Console.WriteLine("Your number is too high");
else
Console.WriteLine("Your number is too low");
Console.WriteLine();
attempts--;
Console.WriteLine("{0} attempts left!", attempts);
Console.WriteLine();
}
if(win == 0)
{
Console.Clear();
Console.WriteLine();
Console.WriteLine("   YY   YY    OOOOOOO     UU     UU                                 ");
Console.WriteLine("    YY YY    OO     OO    UU     UU                                 ");
Console.WriteLine("     YYY     OO     OO    UU     UU                                 ");
Console.WriteLine("     YYY     OO     OO    UU     UU                                 ");
Console.WriteLine("     YYY      OOOOOOO      UUUUUUU                                  ");
Console.WriteLine("                                                                    ");
Console.WriteLine("                              WW     WW  II  NN     N      !! !     ");
Console.WriteLine("                              WW     WW  II  N N    N      !! !     ");
Console.WriteLine("                              WW     WW  II  N  N   N      !! !     ");
Console.WriteLine("                              WW     WW  II  N   N  N      !! !     ");
Console.WriteLine("                              WW  W  WW  II  N    N N      !! !     ");
Console.WriteLine("                              WW W W WW  II  N     NN      @@ @     ");
Console.WriteLine("                                                                    ");
Console.WriteLine("                                                                    ");
}
if (attempts == 0)
{
Console.Clear();
Console.WriteLine("   YY   YY    OOOOOOO     UU   UU                                   ");
Console.WriteLine("    YY YY    OO     OO    UU   UU                                   ");
Console.WriteLine("     YYY     OO     OO    UU   UU                                   ");
Console.WriteLine("     YYY     OO     OO    UU   UU                                   ");
Console.WriteLine("     YYY      OOOOOOO      UUUUU                                    ");
Console.WriteLine("                                                                    ");
Console.WriteLine("||--------------                LL        OOOOO    SSSSSS   EEEEEEE ");
Console.WriteLine("||--------------                LL        OOOOO   SS        EE      ");
Console.WriteLine("||           ||                 LL       OO   OO   SS       EE      ");
Console.WriteLine("||          ****                LL       OO   OO     SS     EEEEEEE ");
Console.WriteLine("||        * #  # *              LL       OO   OO       SS   EE      ");
Console.WriteLine("||         * -- *               LL        OOOOO          SS EE      ");
Console.WriteLine("||         __||__               LLLLLLL   OOOOO    SSSSSSS  EEEEEEE ");
Console.WriteLine("||        [  ||  ]                                                  ");
Console.WriteLine("||        [  ||  ]                                                  ");
Console.WriteLine("||        [  ||  ]                                                  ");
Console.WriteLine("||          /  /                                                    ");
Console.WriteLine("||          |  |                                                    ");
Console.WriteLine("||          |  |                                                    ");
Console.WriteLine("||         /  /                                                     ");
}
}
while ((attempts != 0) || (win != 0)) ;
}
}
