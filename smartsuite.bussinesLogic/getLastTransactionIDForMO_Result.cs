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
    
    public partial class getLastTransactionIDForMO_Result
    {
        public long TransactionID { get; set; }
        public Nullable<long> TargetID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public double Amount { get; set; }
        public bool Approved { get; set; }
        public bool Refunded { get; set; }
        public bool Voided { get; set; }
        public bool Delivered { get; set; }
        public Nullable<long> CDRID { get; set; }
        public string GUID { get; set; }
        public Nullable<long> UserID { get; set; }
        public long MessageTransactionID { get; set; }
        public Nullable<decimal> AggregatorTransactionID { get; set; }
        public int MessageStatusID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int NumberOfAttempts { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public int MessageTypeID { get; set; }
        public Nullable<int> ContentTypeID { get; set; }
    }
}
