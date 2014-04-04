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
    
    public partial class Acc_Voucher
    {
        public Acc_Voucher()
        {
            this.Acc_VoucherDtl = new HashSet<Acc_VoucherDtl>();
        }
    
        public string VoucherTypeId { get; set; }
        public string VoucherId { get; set; }
        public int YearId { get; set; }
        public string VoucherLocationID { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public string VoucherRefno { get; set; }
        public string VoucherNotes { get; set; }
        public Nullable<int> VoucherPrintCount { get; set; }
        public bool IsExtrnalVoucher { get; set; }
        public string MainExtraField1 { get; set; }
        public string MainExtraField2 { get; set; }
        public string MainExtraField3 { get; set; }
        public string MainExtraField4 { get; set; }
        public string MainExtraField5 { get; set; }
        public bool IsPost { get; set; }
        public decimal TotalDtlDebitAmount { get; set; }
        public decimal TotalCreditAmount { get; set; }
        public bool AnulTrans { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> UserDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Gnrl_Loctions Gnrl_Loctions { get; set; }
        public virtual Acc_VouchersType Acc_VouchersType { get; set; }
        public virtual ICollection<Acc_VoucherDtl> Acc_VoucherDtl { get; set; }
    }
}
