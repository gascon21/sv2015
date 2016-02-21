/// <summary>
///  Home accounting: Class Transaction (data of an individual transaction)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.16  19-Feb-2016  Nacho: "ToString" slightly more detailed
   0.14  13-Feb-2016  Nacho: Attribute names in singular; prototype for "ToString"
   0.13  12-Feb-2016  Jorge Montalvo, Manuel Coronado, David Gascón: Class Transaction
   0.12  12-Feb-2016  Nacho: "struct" turned into "class" (still public attributes)
 ---------------------------------------------------- */

namespace HomeAccounting2
{
    public class Transaction
    {
        protected byte day;
        protected byte month;
        protected ushort year;
        protected double amount;
        protected string description;
        protected string account;
        protected string category;

        public Transaction(byte day, byte month, ushort year, double amount, string description, string account, string category)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.amount = amount;
            this.description = description;
            this.account = account;
            this.category = category;
        }

        public void SetDay(byte day)
        {
            this.day = day;
        }

        public byte GetDay()
        {
            return this.day;
        }

        public void SetMonth(byte month)
        {
            this.month = month;
        }

        public byte GetMonth()
        {
            return this.month;
        }

        public void SetYear(ushort year)
        {
            this.year = year;
        }

        public ushort GetYear()
        {
            return this.year;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public double GetAmount()
        {
            return this.amount;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetAccount(string account)
        {
            this.account = account;
        }

        public string GetAccount()
        {
            return this.account;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        public string GetCategory()
        {
            return this.category;
        }

        public override string ToString()
        {
            // TO DO: return DD/MM/AAAA + Descript (x40) + Amount + categ + account
            string desc;
            if (description.Length > 40)
                desc = description.Substring(0, 47) + "...";
            else
                desc = description + new string(' ', 40 - description.Length);

            return day.ToString("00")+"/"+
                month.ToString("00") + "/" +
                year.ToString("00") + "  " +
                desc;
        }
    }
}
