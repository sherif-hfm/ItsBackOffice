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
    
    public partial class Ast_Depreciation
    {
        public Ast_Depreciation()
        {
            this.Ast_DepreciationDtl = new HashSet<Ast_DepreciationDtl>();
        }
    
        public int DepreciationId { get; set; }
        public int YearId { get; set; }
        public Nullable<int> DeprecaitionMonth { get; set; }
        public Nullable<int> DeprecaitionYear { get; set; }
        public bool IsPost { get; set; }
        public string DeprecaitionNotes { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> UserDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ICollection<Ast_DepreciationDtl> Ast_DepreciationDtl { get; set; }
    }
}
