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
    
    public partial class UserSubscriptionLogOriginal
    {
        public long UserSubscriptionLogID { get; set; }
        public long UserSubscriptionID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<long> ChangedByUserID { get; set; }
        public Nullable<bool> Subscribed { get; set; }
        public Nullable<System.DateTime> LastPOSVisitDate { get; set; }
        public Nullable<long> CampaignID { get; set; }
    }
}