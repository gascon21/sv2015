/// <summary>
///  Home accounting: Class Transaction (data of an individual transaction)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: "struct" turned into "class" (still public attributes)
 ---------------------------------------------------- */

namespace HomeAccounting2
{
    class Transaction
    {
        public byte days;
        public byte months;
        public ushort years;
        public double amounts;
        public string descriptions;
        public string accounts;
        public string categories;
    }
}
