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
    
    public partial class Campaign
    {
        public Campaign()
        {
            this.CampaignAudio = new HashSet<CampaignAudio>();
            this.CampaignLocation = new HashSet<CampaignLocation>();
            this.DID = new HashSet<DID>();
            this.IVRTree = new HashSet<IVRTree>();
            this.MailBox = new HashSet<MailBox>();
            this.MaxInteractions = new HashSet<MaxInteractions>();
            this.MaxReplies = new HashSet<MaxReplies>();
            this.MessageFlow = new HashSet<MessageFlow>();
            this.PredictiveDialerSchedule = new HashSet<PredictiveDialerSchedule>();
            this.ReferAFriendOffer = new HashSet<ReferAFriendOffer>();
            this.SupportedCarrier = new HashSet<SupportedCarrier>();
            this.Target = new HashSet<Target>();
            this.UserPermissions = new HashSet<UserPermissions>();
        }
    
        public long CampaignID { get; set; }
        public long CompanyID { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public Nullable<int> CampaignTypeID { get; set; }
        public bool UseMXCarrierLookup { get; set; }
        public bool UseNetNumberLookup { get; set; }
        public bool AMD { get; set; }
        public bool LeaveVMail { get; set; }
        public Nullable<bool> SelectedAll { get; set; }
        public string TwitterUsername { get; set; }
        public string TwitterPassword { get; set; }
        public string FBAuthCode { get; set; }
        public string TwitterToken { get; set; }
        public string TwitterTokenSecret { get; set; }
        public Nullable<long> FBFanPageID { get; set; }
        public Nullable<bool> FBUseGlobal { get; set; }
        public Nullable<bool> TwitterUseGlobal { get; set; }
        public string MaxInteractionAutoResponse { get; set; }
        public string InactiveCampaignMessageText { get; set; }
        public Nullable<bool> AlwaysActive { get; set; }
        public Nullable<bool> IsCampaignHidden { get; set; }
    
        public virtual CampaignType CampaignType { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<CampaignAudio> CampaignAudio { get; set; }
        public virtual ICollection<CampaignLocation> CampaignLocation { get; set; }
        public virtual ICollection<DID> DID { get; set; }
        public virtual ICollection<IVRTree> IVRTree { get; set; }
        public virtual ICollection<MailBox> MailBox { get; set; }
        public virtual ICollection<MaxInteractions> MaxInteractions { get; set; }
        public virtual ICollection<MaxReplies> MaxReplies { get; set; }
        public virtual ICollection<MessageFlow> MessageFlow { get; set; }
        public virtual ICollection<PredictiveDialerSchedule> PredictiveDialerSchedule { get; set; }
        public virtual ICollection<ReferAFriendOffer> ReferAFriendOffer { get; set; }
        public virtual ICollection<SupportedCarrier> SupportedCarrier { get; set; }
        public virtual ICollection<Target> Target { get; set; }
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
    }
}
