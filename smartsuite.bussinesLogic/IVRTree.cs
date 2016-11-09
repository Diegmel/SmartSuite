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
    
    public partial class IVRTree
    {
        public IVRTree()
        {
            this.DID = new HashSet<DID>();
            this.IVRTree1 = new HashSet<IVRTree>();
            this.IVRTreeInput = new HashSet<IVRTreeInput>();
            this.IVRTreeInput1 = new HashSet<IVRTreeInput>();
            this.MaxInteractions = new HashSet<MaxInteractions>();
            this.MaxReplies = new HashSet<MaxReplies>();
            this.OutboundCallSchedule = new HashSet<OutboundCallSchedule>();
            this.OutboundCallSubscriptionList = new HashSet<OutboundCallSubscriptionList>();
        }
    
        public long IVRTreeID { get; set; }
        public long CampaignID { get; set; }
        public Nullable<long> ParentIVRTreeID { get; set; }
        public string AudioURL { get; set; }
        public Nullable<long> TargetID { get; set; }
        public string Description { get; set; }
        public bool FileCached { get; set; }
        public Nullable<int> IVRTreeTypeID { get; set; }
    
        public virtual Campaign Campaign { get; set; }
        public virtual ICollection<DID> DID { get; set; }
        public virtual ICollection<IVRTree> IVRTree1 { get; set; }
        public virtual IVRTree IVRTree2 { get; set; }
        public virtual IVRTreeType IVRTreeType { get; set; }
        public virtual Target Target { get; set; }
        public virtual ICollection<IVRTreeInput> IVRTreeInput { get; set; }
        public virtual ICollection<IVRTreeInput> IVRTreeInput1 { get; set; }
        public virtual ICollection<MaxInteractions> MaxInteractions { get; set; }
        public virtual ICollection<MaxReplies> MaxReplies { get; set; }
        public virtual ICollection<OutboundCallSchedule> OutboundCallSchedule { get; set; }
        public virtual ICollection<OutboundCallSubscriptionList> OutboundCallSubscriptionList { get; set; }
    }
}