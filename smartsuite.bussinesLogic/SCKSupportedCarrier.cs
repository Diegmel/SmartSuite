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
    
    public partial class SCKSupportedCarrier
    {
        public long SCKSupportedCarrierID { get; set; }
        public long CarrierID { get; set; }
        public long ShortCodeKeywordID { get; set; }
    
        public virtual Carrier Carrier { get; set; }
    }
}