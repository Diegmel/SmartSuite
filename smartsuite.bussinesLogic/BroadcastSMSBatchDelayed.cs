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
    
    public partial class BroadcastSMSBatchDelayed
    {
        public long BroadcastSMSBatchID { get; set; }
        public string Description { get; set; }
        public string MessageText { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> NextScheduledTime { get; set; }
        public Nullable<System.DateTime> LastRunTime { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<bool> SentToJuggler { get; set; }
        public Nullable<bool> DelayedBroadcast { get; set; }
        public Nullable<long> MessageCount { get; set; }
        public Nullable<long> BroadcastSMSQueueID { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
