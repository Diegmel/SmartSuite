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
    
    public partial class PD_TransactionLog
    {
        public long PDID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public Nullable<long> CampaignID { get; set; }
        public Nullable<int> nMaxTransfers { get; set; }
        public Nullable<int> nEstCallsPerTransfer { get; set; }
        public Nullable<double> IGain { get; set; }
        public Nullable<double> PGain { get; set; }
        public Nullable<double> IMax { get; set; }
        public Nullable<int> nTransfers { get; set; }
        public Nullable<double> nError { get; set; }
        public Nullable<double> nError_Scaled { get; set; }
        public Nullable<double> nRate { get; set; }
        public Nullable<int> nCallsInPDIVRQueue { get; set; }
    }
}