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
    
    public partial class TEMP_QuickVote_Vote
    {
        public long VoteID { get; set; }
        public long C4CampaignID { get; set; }
        public long CallerID { get; set; }
        public int AnswerOptionID { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual TEMP_QuickVote_AnswerOption TEMP_QuickVote_AnswerOption { get; set; }
    }
}
