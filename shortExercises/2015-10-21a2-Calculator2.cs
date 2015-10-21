// Miguel Moya Ortega
// calculator

using System;

public class calculator
{
    public static void Main()
    {
        string answer;
        double total = 0;
        do
        {
            Console.WriteLine ("Enter answer number: ");
            answer = Console.ReadLine ();
            Console.WriteLine ("Enter operation: ");
            char simbol = Convert.ToChar ( Console.ReadLine () );
            Console.WriteLine ("Enter second number: ");
            double second = Convert.ToDouble ( Console.ReadLine () );
            
            if (answer != "bye" )
            {
                
                double first = Convert.ToDouble (answer);
                switch(simbol)
                {
                    case '+': total = first + second; break;
                    case '-': total = first - second; break;
                    case 'x':
                    case '·': 
                    case '*': total = first * second; break;
                    case '/': total = first / second; break;
                }
                
                Console.WriteLine ("{0} {1} {2} = {3}",
                 answer, simbol, second, total );
            }
        }
        while (answer != "bye" );
    }
}
