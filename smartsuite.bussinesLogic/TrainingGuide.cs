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
    
    public partial class TrainingGuide
    {
        public long TrainingGuideID { get; set; }
        public string TrianingGuideFileName { get; set; }
        public string TrainingGuideFilePath { get; set; }
        public string TrainingGuideFileCaption { get; set; }
        public Nullable<decimal> TrainingGuideFileSize { get; set; }
        public bool Active { get; set; }
    }
}