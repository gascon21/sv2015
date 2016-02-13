/// <summary>
///  Home accounting: main menu
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.13  12-Feb-2016  Pedro Perez, Jose Muñoz, Vicente Cuenca
                        Improvements towards use of classes. Not finished.
                      Ruben Blanco: Load and save config (only language, so far)
   0.12  12-Feb-2016  Nacho: Part of a project. "struct" turned into "class" (still public attributes)
   0.11  20-Nov-2015  Sacha Van de Sijpe: Search
   0.10  20-Nov-2015  David Gascón: Sort by month and day
   0.09  13-Nov-2015  Mónica Esteve: View monthly transactions
   0.08  13-Nov-2015  Rubén Blanco: Finished splitting into functions
   0.07  12-Nov-2015  Nacho: Basic support for several functions
   0.06  06-Nov-2015  Sacha Van de Sijpe: Array of structs
   0.05  30-Oct-2015  Victor Carretero: Parallel arrays (up to 100.000 Transaction)
   0.04  30-Oct-2015  Victor Carretero: Parallel arrays (still one transactions)
   0.03  23-Oct-2015  José Vicente Leal: Display one transactions
   0.02  23-Oct-2015  Vicente Cuenca: Enter one transactions
   0.01  16-Oct-2015  Jorge Montalvo: Main menu (switch)
 ---------------------------------------------------- */

using System;
using System.IO;

namespace HomeAccounting2
{
    public class HomeAccounting
    {
        const int SIZE = 100000;
        static Transaction[] transactions = new Transaction[SIZE];
        static uint numElements = 0;


        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1.-Add expense or income");
            Console.WriteLine("2.-View last Transactions");
            Console.WriteLine("3.-Monthly Transactions");
            Console.WriteLine("4.-Account totals");
            Console.WriteLine("5.-Search");
            Console.WriteLine("0.-Exit");
        }


        public static char GetOption()
        {
            Console.WriteLine("Choose an option: ");
            return Console.ReadKey().KeyChar;
        }


        public static void AddTransaction()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the amount:");
            transactions[numElements].amounts =
                Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the description:");
            transactions[numElements].descriptions =
                Console.ReadLine();

            Console.WriteLine("Enter the day:");
            transactions[numElements].days =
                Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter the month:");
            transactions[numElements].months =
                Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            transactions[numElements].years =
                Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Enter the account:");
            transactions[numElements].accounts =
                Console.ReadLine();

            Console.WriteLine("Enter the category:");
            transactions[numElements].categories =
                Console.ReadLine();

            numElements++;
            Sort();
        }


        public static void Sort()
        {
            for (uint i = 0; i < numElements - 1; i++)
                for (uint j = i + 1; j < numElements; j++)
                {
                    if ((transactions[i].months.ToString("00") +
                            transactions[i].days.ToString("00")).CompareTo(
                            transactions[j].months.ToString("00") +
                            transactions[j].days.ToString("00")) > 0)
                    {
                        Transaction temp = transactions[i];
                        transactions[i] = transactions[j];
                        transactions[j] = temp;
                    }
                }
        }


        public static void ViewLastTransactions()
        {
            for (uint i = 0; i < numElements; i++)
                Console.WriteLine("{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
                    transactions[i].days.ToString("00"),
                    transactions[i].months.ToString("00"),
                    transactions[i].years.ToString("0000"),
                    transactions[i].amounts,
                    transactions[i].descriptions,
                    transactions[i].categories,
                    transactions[i].accounts);
            Console.ReadLine();
        }


        public static void ViewTransactionsMonth()
        {
            ushort searchyear;
            byte searchmonth;
            Console.Write("Enter year: ");
            searchyear = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Enter the month: ");
            searchmonth = Convert.ToByte(Console.ReadLine());

            for (uint i = 0; i < numElements; i++)
            {
                if (transactions[i].years == searchyear &&
                    transactions[i].months == searchmonth)
                    Console.WriteLine(
                        "{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
                        transactions[i].days.ToString("00"),
                        transactions[i].months.ToString("00"),
                        transactions[i].years.ToString("0000"),
                        transactions[i].amounts,
                        transactions[i].descriptions,
                        transactions[i].categories,
                        transactions[i].accounts);
            }
            Console.ReadLine();
        }

        public static void Search()
        {
            Console.Write("Enter your search: ");
            string search = Console.ReadLine();
            for (int i = 0; i < numElements; i++)
            {
                if (transactions[i].descriptions.ToLower().Contains(search.ToLower()) ||
                    transactions[i].amounts.ToString() == search)
                {
                    Console.WriteLine(
                    "{0}-{1}-{2}: {3} Euros | {4} (Cat:{5}, Acc:{6})",
                    transactions[i].days.ToString("00"),
                    transactions[i].months.ToString("00"),
                    transactions[i].years.ToString("0000"),
                    transactions[i].amounts,
                    transactions[i].descriptions,
                    transactions[i].categories,
                    transactions[i].accounts);
                }
            }
            Console.ReadLine();
        }


        public static void WarnNotAvailable()
        {
            Console.WriteLine("Option not available");
        }

        public static string LoadConfig()
        {
            if (!File.Exists("language.conf"))
                return "en";
            StreamReader myFile = File.OpenText("language.conf");
            string language = myFile.ReadLine();
            myFile.Close();
            return language;
        }
        
        public static void SaveConfig(string language)
        {
            StreamWriter newFile = File.CreateText("language.conf");
            newFile.WriteLine(language);
            newFile.Close();
        }


        public static void Main()
        {
            string language = LoadConfig();
            char option;
            do
            {
                DisplayMenu();
                option = GetOption();

                switch (option)
                {
                    case '0':
                        break;

                    case '1':
                        AddTransaction();
                        break;

                    case '2':
                        ViewLastTransactions();
                        break;

                    case '3':
                        ViewTransactionsMonth();
                        break;

                    case '4':
                        WarnNotAvailable();
                        break;

                    case '5':
                        Search();
                        break;

                    default:
                        Console.WriteLine("Unknown option");
                        break;
                }
            }
            while (option != '0');
        }
    }

}
