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
    
    public partial class MessageFlowTree
    {
        public MessageFlowTree()
        {
            this.MessageFlowInput = new HashSet<MessageFlowInput>();
            this.MessageFlowInput1 = new HashSet<MessageFlowInput>();
            this.MessageFlowTree1 = new HashSet<MessageFlowTree>();
        }
    
        public long MessageFlowTreeID { get; set; }
        public Nullable<long> MessageFlowID { get; set; }
        public string Description { get; set; }
        public Nullable<long> ParentMessageFlowTreeID { get; set; }
        public Nullable<int> SequenceNumber { get; set; }
        public Nullable<int> TimeoutHours { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    
        public virtual MessageFlow MessageFlow { get; set; }
        public virtual ICollection<MessageFlowInput> MessageFlowInput { get; set; }
        public virtual ICollection<MessageFlowInput> MessageFlowInput1 { get; set; }
        public virtual ICollection<MessageFlowTree> MessageFlowTree1 { get; set; }
        public virtual MessageFlowTree MessageFlowTree2 { get; set; }
    }
}
