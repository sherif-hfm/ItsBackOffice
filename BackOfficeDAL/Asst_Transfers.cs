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
    
    public partial class Asst_Transfers
    {
        public string TransferId { get; set; }
        public System.DateTime TransferDate { get; set; }
        public string AssetId { get; set; }
        public int OldLocation { get; set; }
        public int NewLocation { get; set; }
        public string OldCostCenter { get; set; }
        public string NewCostCenter { get; set; }
        public bool IsPost { get; set; }
    
        public virtual Ast_Assets Ast_Assets { get; set; }
    }
}