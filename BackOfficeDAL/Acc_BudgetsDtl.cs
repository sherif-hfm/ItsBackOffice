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
    
    public partial class Acc_BudgetsDtl
    {
        public int BudgetId { get; set; }
        public int BudgetYearId { get; set; }
        public int BudgetDtlId { get; set; }
        public int BudgetYear { get; set; }
        public string BudgetAccountId { get; set; }
        public string BudgetCostCenterId { get; set; }
        public string BudgetLocationId { get; set; }
        public decimal BdgtDepitAmount { get; set; }
        public decimal BdgtCreditAmount { get; set; }
        public decimal BdgttBalance { get; set; }
        public System.DateTime BdgtFrom { get; set; }
        public System.DateTime BdgtTo { get; set; }
    
        public virtual Acc_Accounts Acc_Accounts { get; set; }
        public virtual Acc_Budgets Acc_Budgets { get; set; }
    }
}