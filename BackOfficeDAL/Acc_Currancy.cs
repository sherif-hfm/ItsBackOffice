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
    
    public partial class Acc_Currancy
    {
        public Acc_Currancy()
        {
            this.Acc_VouchersType = new HashSet<Acc_VouchersType>();
        }
    
        public int CurrancyId { get; set; }
        public string CurrancyName_Ara { get; set; }
        public string CurrancyName_Eng { get; set; }
        public bool IsLocalCurrancy { get; set; }
        public decimal CurrancyRate { get; set; }
        public string CurrancySymbolName_Ara { get; set; }
        public string CyrrancySymbolName_Eng { get; set; }
        public string CurrancySubUnitNmae_Ara { get; set; }
        public string CUrrancySubUnitName_Eng { get; set; }
        public Nullable<int> FractionLength { get; set; }
    
        public virtual ICollection<Acc_VouchersType> Acc_VouchersType { get; set; }
    }
}
