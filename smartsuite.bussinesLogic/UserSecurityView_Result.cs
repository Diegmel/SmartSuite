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
    
    public partial class UserSecurityView_Result
    {
        public long UserSecurityID { get; set; }
        public long UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<long> C4ParentUserID { get; set; }
        public Nullable<bool> ShowSupport { get; set; }
        public string AdminIdentityID { get; set; }
        public Nullable<bool> HasContactsAccess { get; set; }
        public Nullable<long> SREntityID { get; set; }
        public Nullable<bool> HasSmartAnalyticsAccess { get; set; }
    }
}
