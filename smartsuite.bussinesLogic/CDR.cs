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
    
    public partial class CDR
    {
        public CDR()
        {
            this.VoiceMail = new HashSet<VoiceMail>();
        }
    
        public long CDRID { get; set; }
        public long DID { get; set; }
        public long CallerID { get; set; }
        public System.DateTime CallStart { get; set; }
        public Nullable<System.DateTime> CallEnd { get; set; }
        public long UserID { get; set; }
        public string AsteriskIP { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> CDRTypeID { get; set; }
        public int CDRStatusID { get; set; }
    
        public virtual ICollection<VoiceMail> VoiceMail { get; set; }
    }
}
