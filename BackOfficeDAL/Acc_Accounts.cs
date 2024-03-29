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
    
    public partial class Acc_Accounts
    {
        public Acc_Accounts()
        {
            this.Acc_AccountBalances = new HashSet<Acc_AccountBalances>();
            this.Acc_AccountReconcilation = new HashSet<Acc_AccountReconcilation>();
            this.Acc_BudgetsDtl = new HashSet<Acc_BudgetsDtl>();
            this.Acc_CashierTransAccountSetting = new HashSet<Acc_CashierTransAccountSetting>();
            this.Acc_CashierTransAccountSetting1 = new HashSet<Acc_CashierTransAccountSetting>();
            this.Acc_CashierTransAccountSetting2 = new HashSet<Acc_CashierTransAccountSetting>();
            this.Acc_ChequeBook = new HashSet<Acc_ChequeBook>();
            this.Acc_Reconcilation = new HashSet<Acc_Reconcilation>();
            this.Acc_VoucherDtl = new HashSet<Acc_VoucherDtl>();
            this.Acc_VouchersType = new HashSet<Acc_VouchersType>();
            this.Ast_AssetAccountsSetting = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetAccountsSetting1 = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetAccountsSetting2 = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetAccountsSetting3 = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetAccountsSetting4 = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetAccountsSetting5 = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetAccountsSetting6 = new HashSet<Ast_AssetAccountsSetting>();
            this.Ast_AssetSale = new HashSet<Ast_AssetSale>();
        }
    
        public string AccountID { get; set; }
        public string AccountName_Ar { get; set; }
        public string AccountName_Eng { get; set; }
        public int AccountTypeId { get; set; }
        public int AccountLevel { get; set; }
        public Nullable<int> AccountCategoryId { get; set; }
        public bool IsSubAccount { get; set; }
        public bool IsDisableAccount { get; set; }
        public string AccountRef1 { get; set; }
        public string AccountRef2 { get; set; }
        public string ParentId { get; set; }
        public string CurrancyId { get; set; }
        public string GroupAccount { get; set; }
    
        public virtual ICollection<Acc_AccountBalances> Acc_AccountBalances { get; set; }
        public virtual ICollection<Acc_AccountReconcilation> Acc_AccountReconcilation { get; set; }
        public virtual ICollection<Acc_BudgetsDtl> Acc_BudgetsDtl { get; set; }
        public virtual ICollection<Acc_CashierTransAccountSetting> Acc_CashierTransAccountSetting { get; set; }
        public virtual ICollection<Acc_CashierTransAccountSetting> Acc_CashierTransAccountSetting1 { get; set; }
        public virtual ICollection<Acc_CashierTransAccountSetting> Acc_CashierTransAccountSetting2 { get; set; }
        public virtual ICollection<Acc_ChequeBook> Acc_ChequeBook { get; set; }
        public virtual ICollection<Acc_Reconcilation> Acc_Reconcilation { get; set; }
        public virtual ICollection<Acc_VoucherDtl> Acc_VoucherDtl { get; set; }
        public virtual ICollection<Acc_VouchersType> Acc_VouchersType { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting1 { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting2 { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting3 { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting4 { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting5 { get; set; }
        public virtual ICollection<Ast_AssetAccountsSetting> Ast_AssetAccountsSetting6 { get; set; }
        public virtual ICollection<Ast_AssetSale> Ast_AssetSale { get; set; }
    }
}
