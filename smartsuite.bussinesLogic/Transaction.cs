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
    
    public partial class Transaction
    {
        public Transaction()
        {
            this.TransactionLog = new HashSet<TransactionLog>();
        }
    
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
        public Nullable<long> NextMessageFlowTreeID { get; set; }
        public Nullable<long> ShortCodeKeywordID { get; set; }
        public Nullable<long> MessageFlowID { get; set; }
        public string SessionID { get; set; }
        public string BillingLiteral { get; set; }
    
        public virtual ICollection<TransactionLog> TransactionLog { get; set; }
    }
}
