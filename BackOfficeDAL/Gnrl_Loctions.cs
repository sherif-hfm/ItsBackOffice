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
    
    public partial class Gnrl_Loctions
    {
        public Gnrl_Loctions()
        {
            this.Acc_CashierTrans = new HashSet<Acc_CashierTrans>();
            this.Acc_Voucher = new HashSet<Acc_Voucher>();
            this.Ast_Assets = new HashSet<Ast_Assets>();
        }
    
        public string LocationId { get; set; }
        public int LocationTypeId { get; set; }
        public string LocationName_Ara { get; set; }
        public string LocationName_Eng { get; set; }
        public string WareHouseId { get; set; }
        public string CostCenterId { get; set; }
        public bool LocationDisable { get; set; }
    
        public virtual ICollection<Acc_CashierTrans> Acc_CashierTrans { get; set; }
        public virtual ICollection<Acc_Voucher> Acc_Voucher { get; set; }
        public virtual ICollection<Ast_Assets> Ast_Assets { get; set; }
        public virtual Gnrl_LocationType Gnrl_LocationType { get; set; }
    }
}
