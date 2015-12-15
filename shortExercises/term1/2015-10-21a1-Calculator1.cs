// Sacha van de sijpe
// Program password

using System;
public class WhilePassword
{
    public static void Main()
    {
        string answer;
        char operatorSymbol;
        double number1, number2;

        do
        {
            Console.Write("Enter first answer: ");
            answer = Console.ReadLine();
            
            if (answer != "bye")
            {
                number1 = Convert.ToDouble(answer);
                
                Console.Write("Enter operation: ");
                operatorSymbol = Convert.ToChar(Console.ReadLine());
                
                Console.Write("Enter the second answer: ");
                number2 = Convert.ToDouble(Console.ReadLine());
                
                switch (operatorSymbol)
                {
                    case '+':
                        Console.WriteLine("{0}{1}{2}={3}",
                            number1,operatorSymbol,number2,number1+number2);
                        break;
                    case '*':
                    case '.':
                    case 'x':
                        Console.WriteLine("{0}{1}{2}={3}",
                            number1,operatorSymbol,number2,number1*number2);
                        break;
                    case '/':
                        Console.WriteLine("{0}{1}{2}={3}",
                            number1,operatorSymbol,number2,number1/number2);
                        break;
                    case '-':
                        Console.WriteLine("{0}{1}{2}={3}",
                            number1,operatorSymbol,number2,number1-number2);
                        break;
                    default:
                        Console.WriteLine("Enter a valid operator symbol");
                        break;
                }
            }
        }while(answer != "bye");
    }
}
