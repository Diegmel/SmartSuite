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
    
    public partial class GetViewableCampaignsForConfiguration_Result
    {
        public long CampaignID { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public int Selected { get; set; }
        public Nullable<bool> BroadCastable { get; set; }
        public Nullable<bool> Editable { get; set; }
        public Nullable<bool> Importable { get; set; }
        public string TwitterUsername { get; set; }
        public string TwitterPassword { get; set; }
        public string FBAuthCode { get; set; }
        public Nullable<long> FBFanPageID { get; set; }
        public Nullable<bool> FBUseGlobal { get; set; }
        public string TwitterTokenSecret { get; set; }
        public string TwitterToken { get; set; }
        public Nullable<bool> TwitterUseGlobal { get; set; }
        public Nullable<int> CampaignTypeID { get; set; }
    }
}