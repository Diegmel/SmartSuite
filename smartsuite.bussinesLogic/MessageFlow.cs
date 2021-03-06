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
    
    public partial class MessageFlow
    {
        public MessageFlow()
        {
            this.MessageFlowCarrier = new HashSet<MessageFlowCarrier>();
            this.MessageFlowSchedule = new HashSet<MessageFlowSchedule>();
            this.MessageFlowTree = new HashSet<MessageFlowTree>();
            this.ReferAFriendOffer = new HashSet<ReferAFriendOffer>();
        }
    
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
    
        public virtual Campaign Campaign { get; set; }
        public virtual MessageFlowType MessageFlowType { get; set; }
        public virtual ShortCodeKeyword ShortCodeKeyword { get; set; }
        public virtual ICollection<MessageFlowCarrier> MessageFlowCarrier { get; set; }
        public virtual ICollection<MessageFlowSchedule> MessageFlowSchedule { get; set; }
        public virtual ICollection<MessageFlowTree> MessageFlowTree { get; set; }
        public virtual ICollection<ReferAFriendOffer> ReferAFriendOffer { get; set; }
    }
}
