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
    
    public partial class UserSubscription
    {
        public long UserSubscriptionID { get; set; }
        public Nullable<long> MessageFlowID { get; set; }
        public long UserID { get; set; }
        public Nullable<bool> Subscribed { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public Nullable<long> OutboundCallScheduleID { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> LastTimeQueued { get; set; }
        public Nullable<long> PredictiveDialerScheduleID { get; set; }
        public Nullable<bool> IsDoubleOptIn { get; set; }
        public Nullable<bool> IsTargetViewDBLOI { get; set; }
        public Nullable<System.DateTime> DateDoubleOptInSet { get; set; }
        public byte[] UserSubscriptionRowVersion { get; set; }
        public Nullable<long> OptInSourceID { get; set; }
        public Nullable<int> LoyaltyStatusTypeID { get; set; }
        public Nullable<int> LoyaltyPoints { get; set; }
        public Nullable<System.DateTime> DeactivationDate { get; set; }
        public Nullable<System.DateTime> LastPOSVisitDate { get; set; }
        public Nullable<long> CampaignID { get; set; }
        public Nullable<System.DateTime> FirstOptinDate { get; set; }
    }
}