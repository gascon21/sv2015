/// <summary>
///  Home accounting: main menu
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.18  15-Abr-2016  Monica Esteve, Jose Vicente: Improved usability
   0.17  26-Feb-2016  Nacho: Load and save data, minor corrections
   0.16  19-Feb-2016  Ruben blanco and Indra:
                        Changes on all the TranslatorClass-involved changes and the fancy welcome screen
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
        protected static string language;

        public HomeAccounting()
        {
            transactions = new TransactionsList();
            language = "en";
        }

        public void DisplayMenu()
        {
            Console.Clear();
            EnhancedConsole.WriteCenteredAt(2, 'y', "Home Accounting");
            EnhancedConsole.WriteAt(10, 5, 'c',"1.-" + Translator.GetTranslation(language,"addtr"));
            EnhancedConsole.WriteAtNextRow("2.-"+ Translator.GetTranslation(language,"viewtr"));
            EnhancedConsole.WriteAtNextRow("3.-" + Translator.GetTranslation(language, "monthtr"));
            EnhancedConsole.WriteAtNextRow("4.-" +Translator.GetTranslation(language, "accountstr"));
            EnhancedConsole.WriteAtNextRow("5.-" +Translator.GetTranslation(language, "searchtr"));
            EnhancedConsole.WriteAtNextRow("6.-" + Translator.GetTranslation(language, "lchange"));
            EnhancedConsole.WriteAtNextRow("0.-" +Translator.GetTranslation(language, "exits"));

            EnhancedConsole.WriteAt(10, 14, '0', "");
        }


        public char GetOption()
        {
            Console.Write(Translator.GetTranslation(language, "chosse"));
            return Console.ReadKey().KeyChar;
        }


        public void AddTransaction()
        {
            Console.WriteLine();
            Console.Write
                (Translator.GetTranslation(language, "askamount"));
            string amount = Console.ReadLine();

            // "C" can be used to Cancel
            if (amount.ToUpper() == "C")
                return;

            Console.Write(Translator.GetTranslation(language, "askdesctr"));
            string description = Console.ReadLine();

            Console.Write(Translator.GetTranslation(language, "askday"));
            byte day = Convert.ToByte(Console.ReadLine());

            Console.Write(Translator.GetTranslation(language, "askmonth"));
            byte month = Convert.ToByte(Console.ReadLine());

            Console.Write(Translator.GetTranslation(language, "askyear"));
            ushort year = Convert.ToUInt16(Console.ReadLine());

            Console.Write(Translator.GetTranslation(language, "askaccount"));
            string account = Console.ReadLine();

            Console.Write(Translator.GetTranslation(language, "askcategory"));
            string category = Console.ReadLine();

            transactions.Add(new Transaction(day, month, year, Convert.ToDouble(amount),
                description, account, category));

        }


        public void ViewLastTransactions()
        {
            Console.WriteLine();
            ShowWithNoScroll( transactions.GetLastDataAsText(20) );
        }


        public void ViewTransactionsInAMonth()
        {
            ushort searchyear;
            byte searchmonth;
            Console.WriteLine();
            Console.Write(Translator.GetTranslation(language, "askyear"));
            searchyear = Convert.ToUInt16(Console.ReadLine());
            Console.Write(Translator.GetTranslation(language, "askmonth"));
            searchmonth = Convert.ToByte(Console.ReadLine());

            ShowWithScroll(transactions.GetDataInAMonthAsText(searchmonth, searchyear));

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
            Console.WriteLine();
            Console.Write(Translator.GetTranslation(language, "searchtr"));
            string search = Console.ReadLine();

            ShowWithScroll(transactions.GetSearchResultsAsText(search));

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
            Console.WriteLine(Translator.GetTranslation(language, "invalidoption"));
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

        public void ChangeLanguage()
        {
            Console.WriteLine();
            Console.WriteLine(Translator.GetTranslation(language, "langchoose"));
            language = Console.ReadLine();
            if ((language.ToUpper() != "ES") && (language.ToUpper() != "EN") && 
                (language.ToUpper() != "CA"))
                Console.WriteLine(Translator.GetTranslation(language, "invalidoption"));
            else
                SaveConfig(language);
            
        }


        public void Run()
        {
            IntroScreen intro = new IntroScreen();
            transactions.Load();
            intro.Show();

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

                    case '6':
                        ChangeLanguage();
                        break;

                    default:
                        Console.WriteLine(Translator.GetTranslation(language, "unknow"));
                        break;
                }
            }
            while (option != '0');
            transactions.Save();
        }

        private void ShowWithNoScroll(string[] data)
        {
            // TO DO: Complete, so that it shows the first 20 lines
            if ((data != null) && (data.Length > 0))
            {
                Console.Clear();
                Console.WriteLine(data[0]);
            }
            Console.Write(Translator.GetTranslation(language, "keypress"));
            Console.ReadKey();
        }


        private void ShowWithScroll(string[] data)
        {
            // TO DO: Complete, so that it shows the first 20 lines
            // and then allows to scroll up and down
            if ((data != null) && (data.Length > 0))
            {
                Console.Clear();
                Console.WriteLine(data[0]);
            }
            Console.Write(Translator.GetTranslation(language, "keypress"));
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
