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
    
    public partial class DecisionTree
    {
        public long DecisionTreeID { get; set; }
        public long CampaignID { get; set; }
        public int DecisionPoolID { get; set; }
        public Nullable<long> intParam1 { get; set; }
        public Nullable<long> intParam2 { get; set; }
        public string charParam1 { get; set; }
        public string charParam2 { get; set; }
        public Nullable<long> NextMenuID { get; set; }
        public Nullable<long> NextTargetID { get; set; }
        public string TTS { get; set; }
        public string AudioURL { get; set; }
        public Nullable<long> Transfer { get; set; }
        public string TextMessage { get; set; }
        public Nullable<long> MessageFlowID { get; set; }
    }
}
