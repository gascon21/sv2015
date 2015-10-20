/* 
    Ask the user for his/her login and his/her password (both must be integer
    numbers) and repeat it as many times as necessary, until the entered login
    is "user1" and the password is "password0".
*/

using System;
public class PasswordString
{
    public static void Main()
    {
        string user, password;
    
        do
        {
            Console.Write ("Enter the user: ");
            user = Console.ReadLine();
            
            Console.Write ("Enter the password: ");
            password = Console.ReadLine();
            
            if ((user != "user1") || (password != "password0"))
                Console.WriteLine ("Incorrect user or password!");
        }
        while ((user != "user1") || (password != "password0"));
        
        Console.WriteLine ("Welcome!");
    }
}
