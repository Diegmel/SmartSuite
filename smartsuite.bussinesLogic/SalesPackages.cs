//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smartsuite.bussinesLogic
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesPackages
    {
        public string AccountType { get; set; }
        public string Products { get; set; }
        public string Term { get; set; }
        public Nullable<decimal> TotalOneTimeFee { get; set; }
        public Nullable<decimal> MonthlyRecurringFee { get; set; }
        public int ActionSetID { get; set; }
        public int PackageID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> TermID { get; set; }
        public string LocationRange { get; set; }
        public Nullable<int> LocationRangeID { get; set; }
    }
}
