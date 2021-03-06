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
    
    public partial class ShortCodeKeyword
    {
        public ShortCodeKeyword()
        {
            this.MessageFlow = new HashSet<MessageFlow>();
            this.ReferAFriendOffer = new HashSet<ReferAFriendOffer>();
            this.Target = new HashSet<Target>();
        }
    
        public long ShortCodeKeywordID { get; set; }
        public long ShortCodeInfoID { get; set; }
        public string Keyword { get; set; }
        public decimal Price { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public Nullable<long> ServiceID { get; set; }
        public Nullable<long> UserID { get; set; }
    
        public virtual ICollection<MessageFlow> MessageFlow { get; set; }
        public virtual ICollection<ReferAFriendOffer> ReferAFriendOffer { get; set; }
        public virtual ShortCodeInfo ShortCodeInfo { get; set; }
        public virtual ICollection<Target> Target { get; set; }
    }
}
