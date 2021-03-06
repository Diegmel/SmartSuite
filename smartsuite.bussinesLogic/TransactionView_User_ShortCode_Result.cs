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
    
    public partial class TransactionView_User_ShortCode_Result
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
        public Nullable<long> NextMessageFlowTreeID { get; set; }
        public Nullable<long> ShortCodeKeywordID { get; set; }
        public Nullable<long> MessageFlowID { get; set; }
        public string SessionID { get; set; }
        public string BillingLiteral { get; set; }
        public long ShortCodeKeywordID1 { get; set; }
        public long ShortCodeInfoID { get; set; }
        public string Keyword { get; set; }
        public decimal Price { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime DateCreated1 { get; set; }
        public bool Active { get; set; }
        public Nullable<long> ServiceID { get; set; }
        public Nullable<long> UserID1 { get; set; }
        public long ShortCodeInfoID1 { get; set; }
        public long ShortCode { get; set; }
        public int ShortCodeProviderID { get; set; }
        public string Login1 { get; set; }
        public string Password1 { get; set; }
        public System.DateTime DateCreated2 { get; set; }
        public string Description { get; set; }
        public long CompanyID { get; set; }
        public string mBloxProfileID { get; set; }
        public string mBloxServerURL { get; set; }
        public bool Active1 { get; set; }
        public int ShortCodeTransportID { get; set; }
        public bool HighVolumeEnabled { get; set; }
        public long UserID2 { get; set; }
        public long CompanyID1 { get; set; }
        public int UserTypeID { get; set; }
        public Nullable<long> Phone { get; set; }
        public System.DateTime DateCreated3 { get; set; }
        public bool Active2 { get; set; }
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
    }
}
