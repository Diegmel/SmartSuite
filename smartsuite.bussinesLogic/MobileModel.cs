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
    
    public partial class MobileModel
    {
        public MobileModel()
        {
            this.MobileInfo = new HashSet<MobileInfo>();
        }
    
        public long MobileModelID { get; set; }
        public int ManufacturerID { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<MobileInfo> MobileInfo { get; set; }
    }
}
