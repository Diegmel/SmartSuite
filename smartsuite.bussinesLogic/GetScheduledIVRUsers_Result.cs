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
    
    public partial class GetScheduledIVRUsers_Result
    {
        public Nullable<long> CampaignID { get; set; }
        public long UserID { get; set; }
        public Nullable<long> Phone { get; set; }
        public long DID { get; set; }
        public long OutboundCallScheduleID { get; set; }
        public bool AMD { get; set; }
        public bool LeaveVMail { get; set; }
        public Nullable<long> SpoofID { get; set; }
        public string Schedule { get; set; }
    }
}