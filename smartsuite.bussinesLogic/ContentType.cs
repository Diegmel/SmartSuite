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
    
    public partial class ContentType
    {
        public ContentType()
        {
            this.Target = new HashSet<Target>();
        }
    
        public int ContentTypeID { get; set; }
        public string Description { get; set; }
        public string ServiceBaseURL { get; set; }
    
        public virtual ICollection<Target> Target { get; set; }
    }
}
