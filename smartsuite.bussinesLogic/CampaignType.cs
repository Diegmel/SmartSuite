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
    
    public partial class CampaignType
    {
        public CampaignType()
        {
            this.Campaign = new HashSet<Campaign>();
        }
    
        public int CampaignTypeID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Campaign> Campaign { get; set; }
    }
}
