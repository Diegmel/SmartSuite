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
    
    public partial class BroadcastSMSFilter
    {
        public int BroadcastSMSFilterID { get; set; }
        public int BroadcastSMSFilterTypeID { get; set; }
        public string FilterValue { get; set; }
        public long BroadCastSMSQueueID { get; set; }
    
        public virtual BroadcastSMSFilterType BroadcastSMSFilterType { get; set; }
        public virtual BroadcastSMSQueue BroadcastSMSQueue { get; set; }
    }
}
