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
    
    public partial class BroadcastSMSArchive
    {
        public long BroadcastSMSID { get; set; }
        public Nullable<long> CampaignID { get; set; }
        public long ShortCodeInfoID { get; set; }
        public long UserID { get; set; }
        public string MessageText { get; set; }
        public int MessageTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public int MessageStatusID { get; set; }
        public Nullable<int> BroadcastSMSBatchID { get; set; }
        public Nullable<long> TransactionID { get; set; }
        public Nullable<bool> IsFirstDblOptInBroadCastSend { get; set; }
    }
}