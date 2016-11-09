using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace smartsuite.data.Repository
{
    public class Address
    {
        public int AddressID { get; set; }
        public int UserID { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class User
    {
        public User()
        {
            this.Address = new List<Address>();
        }

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<Address> Address { get; set; }
    }

    public class UserSecurity
    {

        public long UserID { get; set; }
        public long CompanyID { get; set; }
        public long CampaignID { get; set; }
        public int UserTypeID { get; set; }
        public int UserTimeZoneID { get; set; }
        public string CompanyName { get; set; }
        public string CampaignDesc { get; set; }
        public string LogoURL { get; set; }
        public int CanViewCustomMessageFlows { get; set; }
        public int CanViewTargets { get; set; }
        public int LikeDislikeEnabled { get; set; }
        public int DelayedOptin { get; set; }
        public int CountdownTime { get; set; }
        public int EnableDelayedOptin { get; set; }
        public int EnableCountdowntime { get; set; }
        public string FBAuthCode { get; set; }
        public long FBFanPageID { get; set; }
        public string TwitterUsername { get; set; }
        public string TwitterPassword { get; set; }
        public string TwitterTokenSecret { get; set; }
        public string TwitterToken { get; set; }
        public int hassocialaccess { get; set; }
        public int hasfeedbackaccess { get; set; }
        public int hasstamptaccess { get; set; }
        public int hasdisplayaccess { get; set; }
        public int hasKeywordLookupAccess { get; set; }
        public int hasreminderaccess { get; set; }
        public int HasSalesAccess { get; set; }
        public int HasRandomDrawAccess { get; set; }
        public int CanCreateMessagingCampaign { get; set; }
        public int CanCreatePollingCampaign { get; set; }
        public int CanCreateIVRCampaign { get; set; }
        public string ReminderCompanyName { get; set; }
        public long ReminderCompanyPhone { get; set; }
        public long ReminderMessageFlowID { get; set; }
        public long ReminderTargetID { get; set; }
        public long ReminderCampaignID { get; set; }
        public string ReminderTimeZone { get; set; }
        public long crmid { get; set; }
        public string Email { get; set; }
        public int ShowSupport { get; set; }
        public long merchantid { get; set; }
        public int TCPATermsAccepted { get; set; }
        public int SalesRepTypeId { get; set; }
        public int LoyaltyStatus { get; set; }
        public int HasSmartSMSAccess { get; set; }
        public int HasSmartReceiptAccess { get; set; }
        public int HasContactsAccess { get; set; }
        public string AdminIdentityID { get; set; }
        public int HasSmartAnalyticsAccess { get; set; }
        public long SREntityID { get; set; }
        public int HasExportContacts { get; set; }

    }

    public class UserLogIn
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}