/*  Carla Liarte Felipe
    sk the user for his/her login and his/her password (both must be integer
    numbers) and repeat it as many times as necessary, until the entered login
    is "1100" and the password is "1234".
*/

using System;
public class Password
{
    public static void Main()
    {
        int user;
        int password;
    
        do
        {
            Console.Write ("Enter the user :");
            user  = Convert.ToInt32 (Console.ReadLine() );
            
            Console.Write ("Enter the password :");
            password = Convert.ToInt32 (Console.ReadLine() );
            
            if ((user != 1100) || (password != 1234))
                Console.WriteLine ("Incorrect user or password!");
        }
        while ((user != 1100) || (password != 1234));
        
        Console.WriteLine ("Welcome!");
    }
}
