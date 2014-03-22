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
    
    public partial class Acc_VoucherDtl
    {
        public string VoucherTypeId { get; set; }
        public string VoucherId { get; set; }
        public int YearId { get; set; }
        public int Line_No { get; set; }
        public string AccountId { get; set; }
        public string CostCenterId { get; set; }
        public string DetailRefNo { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int CurrancyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal PaidInvoiceAmount { get; set; }
        public string VoucherDtlNotes { get; set; }
        public string DtlExtrnalField1 { get; set; }
        public string DtlExtrnalField2 { get; set; }
        public string DtlExtrnalField3 { get; set; }
        public string DtlExtrnalField4 { get; set; }
        public string DtlExtrnalField5 { get; set; }
        public bool Reconciled { get; set; }
        public Nullable<System.DateTime> DeliveredDate { get; set; }
        public bool Delivered { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> UserDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Acc_Accounts Acc_Accounts { get; set; }
        public virtual Acc_Voucher Acc_Voucher { get; set; }
        public virtual Acc_CostCenter Acc_CostCenter { get; set; }
    }
}
