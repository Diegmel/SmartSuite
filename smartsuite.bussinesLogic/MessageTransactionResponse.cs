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
    
    public partial class MessageTransactionResponse
    {
        public long MessageTransactionResponseID { get; set; }
        public long MessageTransactionID { get; set; }
        public System.DateTime DateTime { get; set; }
        public string HTTPResponse { get; set; }
        public Nullable<int> ReturnCode { get; set; }
        public string ReturnText { get; set; }
    
        public virtual MessageTransaction MessageTransaction { get; set; }
    }
}
