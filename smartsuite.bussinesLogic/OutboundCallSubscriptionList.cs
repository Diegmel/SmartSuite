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
    
    public partial class OutboundCallSubscriptionList
    {
        public long SubscriptionListID { get; set; }
        public long IVRTreeID { get; set; }
        public long DID { get; set; }
    
        public virtual DID DID1 { get; set; }
        public virtual IVRTree IVRTree { get; set; }
    }
}
