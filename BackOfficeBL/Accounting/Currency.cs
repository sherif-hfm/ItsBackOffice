using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class Currency
    {
        public int CurrencyID { get; set; }
        public string CurrencyName { get { return GetCurrencynName(); } }
        public string CurrencyArName { get; set; }
        public string CurrencyEnName { get; set; }

        private string GetCurrencynName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.CurrencyEnName;
                case "ar-KW":
                    return this.CurrencyArName;
                default:
                    return this.CurrencyEnName;
            }
        }
    }
}
