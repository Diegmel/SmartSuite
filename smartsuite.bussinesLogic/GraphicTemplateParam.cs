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
    
    public partial class GraphicTemplateParam
    {
        public string GraphicTemplateParamKey { get; set; }
        public int GraphicTemplateId { get; set; }
        public string Title { get; set; }
        public string ParamValue { get; set; }
    
        public virtual GraphicTemplate GraphicTemplate { get; set; }
    }
}
