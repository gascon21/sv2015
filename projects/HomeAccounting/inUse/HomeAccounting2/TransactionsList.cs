/// <summary>
///  Home accounting: Class TransactionList (group of transactions)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: Empty skeleton
   0.13  12-Feb-2016  Chen Chao, Sergio Martínez, Gonzalo García: Added basic methods
 ---------------------------------------------------- */

 using System;
using System.Collections;
using System.IO;

namespace HomeAccounting2
{
    class TransactionsList
    {
        protected ArrayList transactions;

        // This constructor creates a new arraylist of transaction.
        public TransactionsList()
        {
            transactions = new ArrayList(); 
        }


        // This method adds a new transaction.
        public void Add(Transaction newtransaction)
        {
            transactions.Add(newtransaction);     
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
            return (Transaction) transactions[position];
        }


        // This method returns the last transaction added.
        public Transaction GetLast()
        {
            return (Transaction)transactions[Count() - 1];
        }


        // This method returns the total amount of transactions.
        public int Count()
        {
            return transactions.Count;
        }  

        
        public string[] GetResult(byte month, ushort year)
        {
            /*
            ArrayList transactionsByMonthYear = new ArrayList();
            
            if (Count() > 0)
            {
                int amount = 0;

                for (int i = 0; i < Count(); i++)  
                    if (transactions[i].GetMonths() == month &&
                            transactions[i].GetYears() == year)
                        amount++;  

                string[] result = new string[amount];

                for (int i = 0; i < result.Length; i++)
                {
                    result = "" + transactions[i].GetDays().ToString("00") + "/" +
                        transactions[i].GetMonths().ToString("00") + "/" +
                        transactions[i].GetYears().ToString("0000") + " ";
                }

                return result;
            }  
            */
            return null;
        }
        
        
        public void Load()
        {
            string line;
            StreamReader dataFile = File.OpenText("data.dat");
            do
            {
                line = dataFile.ReadLine();
                if (line != null)
                {
                    string[] data = line.Split('|');
                    /*
                    Add( new Transaction(Convert.ToByte(data[0]), 
                        Convert.ToByte(data[1]), 
                        Convert.ToUInt16(data[2]), 
                        Convert.ToDouble(data[3]), 
                        data[4], data[5], data[6]));
                    */
                }
            } 
            while (line != null);
            dataFile.Close();
        }


        public void Save()
        {
            StreamWriter dataFile = File.CreateText("data.dat");
            /*
            for (int i = 0; i < transactions.Count; i++)
                configFile.WriteLine(transactions[i].GetDays() + "|" + transactions[i].GetMonths
                    + "|" + transactions[i].GetYears + "|" + transactions[i].GetAmounts
                        + "|" + transactions[i].GetDescriptions + "|" + transactions[i].GetAccounts
                            + "|" + transactions[i].GetCategories);
            */        
            dataFile.Close();
        }
 
    }
}
