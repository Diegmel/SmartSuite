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
    
    public partial class MessageFlowView_ShortCodeKeywordID_CarrierID_Result
    {
        public long MessageFlowID { get; set; }
        public string Description { get; set; }
        public long CampaignID { get; set; }
        public Nullable<long> ShortCodeKeywordID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public Nullable<long> MessageFlowTypeID { get; set; }
        public Nullable<long> MessageFlowScheduleID { get; set; }
        public Nullable<long> MonthlyRebillTargetID { get; set; }
        public Nullable<System.DateTime> DateDBLOptInBroadcastSent { get; set; }
        public Nullable<bool> DBLOptInProcessed { get; set; }
        public Nullable<bool> DBLOptInBroadcastSent { get; set; }
        public Nullable<bool> IsFirstDblOptInBroadCastSend { get; set; }
        public Nullable<bool> IsManuallyCreated { get; set; }
        public Nullable<bool> IsDefaultSubscriptionList { get; set; }
        public long MessageFlowCarrierID { get; set; }
        public long CarrierID { get; set; }
        public long MessageFlowID1 { get; set; }
    }
}