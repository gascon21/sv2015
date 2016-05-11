/// <summary>
///  Home accounting: Class TransactionList (group of transactions)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.19  15-Abr-2016  Indra, corrections by Nacho: implement GetSearchResultsAsText 
                        and GetDataInAMonthAsText
   0.17  26-Feb-2016  Nacho: Check errors when loading
   0.16  19-Feb-2016  Mas, Esteve, Van de sijpe: GetLastDataAsText
   0.15  18-Feb-2016  Nacho: Skeleton for GetLastDataAsText
   0.14  13-Feb-2016  Nacho: Save & Load Enabled. Sort brought from Main 
                        & called after Add; prototype for a few new methods
   0.13  12-Feb-2016  Chen Chao, Sergio Martínez, Gonzalo García: Added basic methods
   0.12  12-Feb-2016  Nacho: Empty skeleton
 ---------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.IO;

namespace HomeAccounting2
{
    public class TransactionsList
    {
        protected List<Transaction> transactions;

        // This constructor creates a new arraylist of transaction.
        public TransactionsList()
        {
            transactions = new List<Transaction>(); 
        }


        // This method adds a new transaction.
        public void Add(Transaction newtransaction)
        {
            transactions.Add(newtransaction);
            Sort();
        }


        // This method removes a transaction at a certain position.
        public void Remove(int position)
        {
            if (Count() > 0)
            {
                transactions.RemoveAt(position);
            }
        }


        // This method returns a transaction at a certain position.
        public Transaction Get(int position)
        {
            return transactions[position];
        }


        // This method returns the last transaction added.
        public Transaction GetLast()
        {
            return transactions[Count() - 1];
        }


        // This method returns the total amount of transactions.
        public int Count()
        {
            return transactions.Count;
        }  

        
        public string[] GetDataInAMonthAsText(byte month, ushort year)
        {
            
            List<string> transactionsByMonthYear = new List<string>();
            //First I check if there are any transactions available
            if (transactions.Count> 0)
            {
                int amount = 0;
                // Here I check all the transactions for coincidences in month and year
                for (int i = 0; i < transactions.Count; i++)
                    if (transactions[i].GetMonth() == month &&
                            transactions[i].GetYear() == year)
                    {
                        transactionsByMonthYear.Add( Get(i).ToString() );
                        amount++;
                    }

                string[] result = new string[amount];

                // If there are no matches, I return null
                if (transactionsByMonthYear.Count == 0)
                {
                    return null;
                }

                // Otherwise, I transform the arrayList into string[] and then return it
                else
                {
                    return transactionsByMonthYear.ToArray();
                    /*string[] resultsTerms = new string[transactionsByMonthYear.Count];
                    for (int j = 0; j < resultsTerms.Length; j++)
                    {
                        resultsTerms[j] = transactionsByMonthYear[j];
                    }
                    return resultsTerms;*/
                }
            }  
            
            return null;
        }

        public string[] GetLastDataAsText(short amount)
        {
            string[] data;

            if (Count() == 0)
                return null;
            if (amount > Count())
                data = new string[Count()];
            else
                data = new string[amount];

            for (int i = 0; i < data.Length; i++)
            {
                if (amount > Count())
                    data[i] = Get(i).ToString();
                else
                    data[i] = Get(Count() - amount + i).ToString();
            }
               
            return data;
        }

        public string[] GetSearchResultsAsText(string searchText)
        {
            //First I check if there are any transaction created
            if (transactions.Count >0)
            {
                // I create a List of strings to store all the results
                List<string> searchResults = new List<string>();

                // Then I proceed to check all the transactions looking for coincidences in
                // their description, account o category, adding if is there any of them
                for (int i = 0; i < transactions.Count; i++)
                {
                    if (transactions[i].GetDescription().Contains(searchText)
                            || transactions[i].GetAccount().Contains(searchText)
                            || transactions[i].GetCategory().Contains(searchText))
                    {
                        searchResults.Add(Get(i).ToString());
                    }
                }

                // If there are no matches, I return null
                if (searchResults.Count == 0)
                {
                    return null;
                }

                // Otherwise, I transform the arrayList into string[] and then return it
                else
                {
                    string[] resultsTerms = new string[searchResults.Count];
                    for (int j = 0; j < resultsTerms.Length; j++)
                    {
                        resultsTerms[j] = searchResults[j];
                    }
                    return resultsTerms;
                }
            }
            return null;
        }

        public void Sort()
        {
            for (int i = 0; i < Count() - 1; i++)
                for (int j = i + 1; j < Count(); j++)
                {
                    if ((transactions[i].GetMonth().ToString("00") +
                            transactions[i].GetDay().ToString("00")).CompareTo(
                            transactions[j].GetMonth().ToString("00") +
                            transactions[j].GetDay().ToString("00")) > 0)
                    {
                        Transaction temp = transactions[i];
                        transactions[i] = transactions[j];
                        transactions[j] = temp;
                    }
                }
        }


        public void Load()
        {
            if (!File.Exists("data.dat"))
                return;

            string line;
            try
            {
                StreamReader dataFile = File.OpenText("data.dat");
                do
                {
                    line = dataFile.ReadLine();
                    if (line != null)
                    {
                        string[] data = line.Split('|');
                        Add(new Transaction(Convert.ToByte(data[0]),
                            Convert.ToByte(data[1]),
                            Convert.ToUInt16(data[2]),
                            Convert.ToDouble(data[3]),
                            data[4], data[5], data[6]));
                    }
                }
                while (line != null);
                dataFile.Close();
            }
            catch( Exception )
            {
                // Nothing done at this point
            }
        }


        public void Save()
        {
            StreamWriter dataFile = File.CreateText("data.dat");
            for (int i = 0; i < transactions.Count; i++)
                dataFile.WriteLine(transactions[i].GetDay() + "|" + 
                    transactions[i].GetMonth() + "|" + 
                    transactions[i].GetYear() + "|" + 
                    transactions[i].GetAmount() + "|" + 
                    transactions[i].GetDescription() + "|" + 
                    transactions[i].GetAccount() + "|" + 
                    transactions[i].GetCategory());
            dataFile.Close();
        }
 
    }
}
