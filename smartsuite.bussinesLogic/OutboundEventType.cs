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
    
    public partial class OutboundEventType
    {
        public OutboundEventType()
        {
            this.OutboundEventScheduler = new HashSet<OutboundEventScheduler>();
        }
    
        public int OutboundEventTypeID { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    
        public virtual ICollection<OutboundEventScheduler> OutboundEventScheduler { get; set; }
    }
}