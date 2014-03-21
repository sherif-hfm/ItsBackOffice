using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class VoucherValidation
    {
        public int VaidationID { get; set; }
        public string ValidationName { get { return GetValidationName(); } }
        public string ValidationArName { get; set; }
        public string ValidationEnName { get; set; }

        private string GetValidationName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.ValidationEnName;
                case "ar-KW":
                    return this.ValidationArName;
                default:
                    return this.ValidationEnName;
            }
        }

    }
}
