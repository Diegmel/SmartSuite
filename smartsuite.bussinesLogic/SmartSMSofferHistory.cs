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
    
    public partial class SmartSMSofferHistory
    {
        public long SmartSMSofferHistoryID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<long> SmartSMSOfferID { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public string PosKeyDescription { get; set; }
        public string OfferText { get; set; }
        public string LegalFinePrint { get; set; }
        public string Expiration { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ClientOfferID { get; set; }
    }
}
