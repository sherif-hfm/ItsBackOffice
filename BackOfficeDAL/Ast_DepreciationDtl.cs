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
    
    public partial class Ast_DepreciationDtl
    {
        public int DepreciationId { get; set; }
        public int DeprDtlId { get; set; }
        public string AssetId { get; set; }
        public decimal AsstValue { get; set; }
        public decimal DepreciationPrecent { get; set; }
        public decimal DepreciationValue { get; set; }
    
        public virtual Ast_Assets Ast_Assets { get; set; }
        public virtual Ast_Depreciation Ast_Depreciation { get; set; }
    }
}
