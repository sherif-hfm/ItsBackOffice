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
    
    public partial class Ast_AssetSale
    {
        public string AsstSaleId { get; set; }
        public string AssetId { get; set; }
        public Nullable<System.DateTime> AsstSaleDate { get; set; }
        public decimal AssetSaleAmount { get; set; }
        public bool IsPost { get; set; }
        public string AssetSaleNote { get; set; }
        public string CustomerAccountId { get; set; }
    
        public virtual Acc_Accounts Acc_Accounts { get; set; }
    }
}
