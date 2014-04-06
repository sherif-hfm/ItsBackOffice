using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class Voucher
    {
        public string VoucherDate { get; set; }
        public string VoucherRefno { get; set; }
        public string VoucherId { get; set; }
        public string VoucherTypeName { get; set; }
        public string TotalDtlDebitAmount { get; set; }
        public string TotalCreditAmount { get; set; }
        public string SettlementAmount { get; set; }
        public bool Cheked { get; set; }
    }
}
