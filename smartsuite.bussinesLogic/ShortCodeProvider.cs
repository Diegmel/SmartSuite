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
    
    public partial class ShortCodeProvider
    {
        public ShortCodeProvider()
        {
            this.ShortCodeInfo = new HashSet<ShortCodeInfo>();
        }
    
        public int ShortCodeProviderID { get; set; }
        public string Description { get; set; }
        public string ProviderURL { get; set; }
        public string C4SendMessageURL { get; set; }
    
        public virtual ICollection<ShortCodeInfo> ShortCodeInfo { get; set; }
    }
}