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
    
    public partial class Acc_ChequeBook
    {
        public int ChequeBookID { get; set; }
        public string CheuqeBookName_Ara { get; set; }
        public string CheuqeBookName_Eng { get; set; }
        public int ChequeCurrancyId { get; set; }
        public string BankAccountId { get; set; }
        public bool IsDisable { get; set; }
        public int ChequeStartNo { get; set; }
        public int CHequeEndno { get; set; }
    
        public virtual Acc_Accounts Acc_Accounts { get; set; }
    }
}
