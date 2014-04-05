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
    
    public partial class Ast_Revaluated
    {
        public string RevalutedId { get; set; }
        public string AssetId { get; set; }
        public string RevaluatedNotes { get; set; }
        public System.DateTime RevaluatedDate { get; set; }
        public decimal AssetOrginalValue { get; set; }
        public decimal AssetNewValue { get; set; }
        public bool Posted { get; set; }
        public Nullable<System.DateTime> LastRevaluatedDate { get; set; }
        public Nullable<decimal> LastRevaluatedAmount { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> UserDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Ast_Assets Ast_Assets { get; set; }
    }
}