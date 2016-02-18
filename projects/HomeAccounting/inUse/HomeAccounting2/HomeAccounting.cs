/// <summary>
///  Home accounting: main menu
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.15  18-Feb-2016  Nacho: Skeleton for ViewLastTransactions, ShowWithNoScroll
                        Example of use of "Translator" in "DisplayMenu"
   0.14  13-Feb-2016  Nacho: Uses "TransactionList" instead of an array, methods are not static,
                        commented out the parts to be moved to TransactionList.
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
        protected TransactionsList transactions;
        protected string language;

        public HomeAccounting()
        {
            transactions = new TransactionsList();
            language = "en";
        }

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1.-" + Translator.GetTranslation(language,"addtr"));
            Console.WriteLine("2.-View last Transactions");
            Console.WriteLine("3.-Monthly Transactions");
            Console.WriteLine("4.-Account totals");
            Console.WriteLine("5.-Search");
            Console.WriteLine("0.-Exit");
        }


        public char GetOption()
        {
            Console.Write("Choose an option: ");
            return Console.ReadKey().KeyChar;
        }


        public void AddTransaction()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter the day:");
            byte day = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter the month:");
            byte month = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            ushort year = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Enter the account:");
            string account = Console.ReadLine();

            Console.WriteLine("Enter the category:");
            string category = Console.ReadLine();

            transactions.Add(new Transaction(day, month, year, amount,
                description, account, category));
        }


        public void ViewLastTransactions()
        {
            ShowWithNoScroll( transactions.GetLastDataAsText(20) );
        }


        public void ViewTransactionsInAMonth()
        {
            ushort searchyear;
            byte searchmonth;
            Console.Write("Enter year: ");
            searchyear = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Enter the month: ");
            searchmonth = Convert.ToByte(Console.ReadLine());
            /* TO DO: Ask TransactionsList for the info */
            /*
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
            */
        }

        public void Search()
        {
            Console.Write("Enter your search: ");
            string search = Console.ReadLine();
            /* TO DO: Ask TransactionsList for the info */
            /*
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
            */
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


        public void Run()
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
                        ViewTransactionsInAMonth();
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

        private void ShowWithNoScroll(string[] data)
        {
            // TO DO: Complete, so that it shows the first 20 lines
            if ((data != null) && (data.Length > 0))
            {
                Console.Clear();
                Console.WriteLine(data[0]);
            }
            Console.Write("Press a key to return ");
            Console.ReadKey();
        }

        // -----------------------------------------

        public static void Main()
        {
            HomeAccounting accounting = new HomeAccounting();
            accounting.Run();
        }

    }
}
