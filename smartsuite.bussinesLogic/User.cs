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
    
    public partial class User
    {
        public User()
        {
            this.MailBox = new HashSet<MailBox>();
            this.MessageDetails = new HashSet<MessageDetails>();
            this.Messages = new HashSet<Messages>();
            this.OutboundEventScheduler = new HashSet<OutboundEventScheduler>();
            this.ScheduledReports = new HashSet<ScheduledReports>();
            this.UserInfo = new HashSet<UserInfo>();
            this.UserKeyword = new HashSet<UserKeyword>();
            this.UserPermissions = new HashSet<UserPermissions>();
            this.UserPermissionsDisplayGraphic = new HashSet<UserPermissionsDisplayGraphic>();
            this.UserProduct = new HashSet<UserProduct>();
            this.UserSecurity = new HashSet<UserSecurity>();
            this.VoiceMail = new HashSet<VoiceMail>();
        }
    
        public long UserID { get; set; }
        public long CompanyID { get; set; }
        public int UserTypeID { get; set; }
        public Nullable<long> Phone { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public Nullable<long> MobileModelID { get; set; }
        public Nullable<long> CarrierID { get; set; }
        public Nullable<int> TimeZoneID { get; set; }
        public string MobileDeviceName { get; set; }
        public string AccountNum { get; set; }
        public string PIN { get; set; }
        public string TwitterUsername { get; set; }
        public string TwitterPassword { get; set; }
        public string FBAuthCode { get; set; }
        public string TwitterToken { get; set; }
        public string TwitterTokenSecret { get; set; }
        public Nullable<bool> HasSocialAccess { get; set; }
        public Nullable<long> FBFanPageID { get; set; }
        public Nullable<bool> HasFeedbackAccess { get; set; }
        public Nullable<bool> HasStamptAccess { get; set; }
        public Nullable<bool> HasDisplayAccess { get; set; }
        public Nullable<bool> HasKeywordLookupAccess { get; set; }
        public Nullable<bool> HasReminderAccess { get; set; }
        public Nullable<bool> TCPATermsAccepted { get; set; }
        public Nullable<System.DateTime> DateTCPATermsAccepted { get; set; }
        public Nullable<int> SalesRepTypeId { get; set; }
        public Nullable<bool> HasSalesAccess { get; set; }
        public Nullable<bool> CanCreateMessagingCampaign { get; set; }
        public Nullable<bool> CanCreatePollingCampaign { get; set; }
        public Nullable<bool> CanCreateIVRCampaign { get; set; }
        public byte[] UserRowVersion { get; set; }
        public Nullable<bool> HasRandomDrawAccess { get; set; }
        public Nullable<int> LoyaltyStatus { get; set; }
        public Nullable<bool> HasSmartSMSAccess { get; set; }
        public Nullable<bool> HasSmartReceiptAccess { get; set; }
        public string OttUserID { get; set; }
        public bool HasExportContacts { get; set; }
    
        public virtual ICollection<MailBox> MailBox { get; set; }
        public virtual ICollection<MessageDetails> MessageDetails { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<OutboundEventScheduler> OutboundEventScheduler { get; set; }
        public virtual ICollection<ScheduledReports> ScheduledReports { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public virtual ICollection<UserKeyword> UserKeyword { get; set; }
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
        public virtual ICollection<UserPermissionsDisplayGraphic> UserPermissionsDisplayGraphic { get; set; }
        public virtual ICollection<UserProduct> UserProduct { get; set; }
        public virtual ICollection<UserSecurity> UserSecurity { get; set; }
        public virtual ICollection<VoiceMail> VoiceMail { get; set; }
    }
}
