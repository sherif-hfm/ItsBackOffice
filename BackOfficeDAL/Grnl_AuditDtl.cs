//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackOfficeDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grnl_AuditDtl
    {
        public long AuditDtlId { get; set; }
        public long AuditId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyOriginalValues { get; set; }
        public string PropertyCurrentValues { get; set; }
    
        public virtual Grnl_Audit Grnl_Audit { get; set; }
    }
}