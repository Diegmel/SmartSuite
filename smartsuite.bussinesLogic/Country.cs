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
    
    public partial class Country
    {
        public Country()
        {
            this.Carrier = new HashSet<Carrier>();
            this.States = new HashSet<States>();
        }
    
        public int CountryID { get; set; }
        public string Description { get; set; }
        public string DialingCode { get; set; }
    
        public virtual ICollection<Carrier> Carrier { get; set; }
        public virtual ICollection<States> States { get; set; }
    }
}
