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
    
    public partial class GetScheduleReport_Result
    {
        public long ID { get; set; }
        public string ReportName { get; set; }
        public int ReportTypeID { get; set; }
        public int TimePeriodID { get; set; }
        public string CampaignIDs { get; set; }
        public System.DateTime StartDate { get; set; }
        public int RepeatTypeID { get; set; }
        public int RepeatInterval { get; set; }
        public Nullable<bool> IsMon { get; set; }
        public Nullable<bool> IsTue { get; set; }
        public Nullable<bool> IsWed { get; set; }
        public Nullable<bool> IsThu { get; set; }
        public Nullable<bool> IsFri { get; set; }
        public Nullable<bool> IsSat { get; set; }
        public Nullable<bool> IsSun { get; set; }
        public Nullable<bool> NeverEnds { get; set; }
        public Nullable<int> EndsAfterOccurrences { get; set; }
        public Nullable<System.DateTime> EndsOn { get; set; }
        public string Recipients { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsEnded { get; set; }
        public string TimePeriodDesc { get; set; }
        public string ReportTypeDesc { get; set; }
        public string RepeatTypeDesc { get; set; }
    }
}
