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
    
    public partial class Ast_DepreciationMethod
    {
        public Ast_DepreciationMethod()
        {
            this.Ast_Assets = new HashSet<Ast_Assets>();
        }
    
        public int DepreciationId { get; set; }
        public string DepreciationName_Ara { get; set; }
        public string DepreciationName_Eng { get; set; }
    
        public virtual ICollection<Ast_Assets> Ast_Assets { get; set; }
    }
}
