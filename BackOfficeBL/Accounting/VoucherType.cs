using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class VoucherType
    {
        public string VoucherTypeId { get; set; }

        public string VoucherName { get { return GetVoucherName(); } }
        public string VoucherArName { get; set; }
        public string VoucherEnName { get; set; }
        public string ShortName_Ara { get; set; }
        public string ShortName_Eng { get; set; }

        public string CriedtAccountID { get; set; }
        public int CurrencyID { get; set; }

        public string DetailExtraField1 { get; set; }
        public string DetailExtraField2 { get; set; }
        public string DetailExtraField3 { get; set; }
        public string DetailExtraField4 { get; set; }
        public string DetailExtraField5 { get; set; }

        public string MainExtraField1 { get; set; }
        public string MainExtraField2 { get; set; }
        public string MainExtraField3 { get; set; }
        public string MainExtraField4 { get; set; }
        public string MainExtraField5 { get; set; }

        public string DepitAccountId { get; set; }

        public int? DtlValidationField1 { get; set; }
        public int? DtlValidationField2 { get; set; }
        public int? DtlValidationField3 { get; set; }
        public int? DtlValidationField4 { get; set; }
        public int? DtlValidationField5 { get; set; }

        public int? MainValidationField1 { get; set; }// Elhaddad update convert from int to string
        public int? MainValidationField2 { get; set; }// Elhaddad update convert from int to string
        public int? mainValidationField3 { get; set; }// Elhaddad update convert from int to string
        public int? MainValidationField4 { get; set; }// Elhaddad update convert from int to string
        public int? MainValidationField5 { get; set; }// Elhaddad update convert from int to string




        private string GetVoucherName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.VoucherEnName;
                case "ar-KW":
                    return this.VoucherArName;
                default:
                    return this.VoucherEnName;
            }
        }

    }
    public class Gidlist
    {

        //  public string VoucherTypeId { get; set; }

        // public string VoucherName { get { return GetVoucherName(); } }
        public string VoucherArName { get; set; }
        public string VoucherEnName { get; set; }
        public string ShortName_Ara { get; set; }
        public string ShortName_Eng { get; set; }
    }
}
