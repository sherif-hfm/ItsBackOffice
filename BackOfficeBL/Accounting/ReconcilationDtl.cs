using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class ReconcilationDtl
    {
        public int ReconcileDtlid { get; set; }
        public string ReconcileId { get; set; }
        public string VoucherId { get; set; }
        public string VoucherNo { get; set; }
    }
}
