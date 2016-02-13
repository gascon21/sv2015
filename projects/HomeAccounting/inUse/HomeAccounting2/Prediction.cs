/// <summary>
///  Home accounting: Class Predictions  (data of an individual prediction)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: Empty skeleton
   0.13  12-Feb-2016  Jorge Montalvo, Manuel Coronado, David Gascón: Class Prediction
 ---------------------------------------------------- */

namespace HomeAccounting2
{
    class Prediction
    {
        protected byte days;
        protected byte months;
        protected double amounts;
        protected string descriptions;
        protected string accounts;
        protected string categories;

        public Prediction(byte days, byte months, double amounts, 
            string descriptions, string accounts, string categories)
        {
            this.days = days;
            this.months = months;
            this.amounts = amounts;
            this.descriptions = descriptions;
            this.accounts = accounts;
            this.categories = categories;
        }

        public void SetDays(byte days)
        {
            this.days = days;
        }
        
        public byte GetDays()
        {
            return days;
        }

        public void SetMonths(byte months)
        {
            this.months = months;
        }

        public byte GetMonths()
        {
            return months;
        }

        public void SetAmounts(double amounts)
        {
            this.amounts = amounts;
        }

        public double GetAmounts()
        {
            return amounts;
        }

        public void SetDescriptions(string descriptions)
        {
            this.descriptions = descriptions;
        }

        public string GetDescription()
        {
            return descriptions;
        }

        public void SetAccounts(string accounts)
        {
            this.accounts = accounts;
        }

        public string GetAccounts()
        {
            return accounts;
        }

        public void SetCategories(string categories)
        {
            this.categories = categories;
        }

        public string GetCategories()
        {
            return categories;
        }
    }
}
