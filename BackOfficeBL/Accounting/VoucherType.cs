using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BackOfficeDAL;

namespace BackOfficeBL.Accounting
{
    public class VoucherType
    {

        private NewAppsCnn DBContext = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);


        public string VoucherTypeId { get; set; }

        public string VoucherName { get { return GetVoucherName(); } }
        public string VoucherArName { get; set; }
        public string VoucherEnName { get; set; }
        public string ShortName_Ara { get; set; }
        public string ShortName_Eng { get; set; }

        public string CriedtAccountID { get; set; }
        public int VoucherTypeCurrencyID { get; set; }

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

        public int? MainValidationField1 { get; set; }
        public int? MainValidationField2 { get; set; }
        public int? mainValidationField3 { get; set; }
        public int? MainValidationField4 { get; set; }
        public int? MainValidationField5 { get; set; }
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


        public static List<VoucherType> GetAllVouchers()
        {
            List<VoucherType> VoucherTypeList = new List<VoucherType>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var VouchrsType = from type in newAppsCnn.Acc_VouchersType select type;
            foreach (var voucher in VouchrsType)
            {
                VoucherType VoucherType = new VoucherType();
                VoucherType.VoucherTypeId = voucher.VoucherTypeId;
                VoucherType.VoucherEnName = voucher.VoucherNmae_Eng;
                VoucherType.VoucherArName = voucher.VoucherName_Ara;
                VoucherType.ShortName_Ara = voucher.ShortName_Ara;
                VoucherType.ShortName_Eng = voucher.ShortName_Eng;

                VoucherType.CriedtAccountID = voucher.CreditAccountid;
                VoucherType.DepitAccountId = voucher.DepitAccountId;
                VoucherType.VoucherTypeCurrencyID = Convert.ToInt32(voucher.VoucherCurrancyid);

                VoucherType.MainExtraField1 = voucher.MainExtraField1;
                VoucherType.MainExtraField2 = voucher.MainExtraField2;
                VoucherType.MainExtraField3 = voucher.MainExtraField3;
                VoucherType.MainExtraField4 = voucher.MainExtraField4;
                VoucherType.MainExtraField5 = voucher.MainExtraField5;

                VoucherType.DetailExtraField1 = voucher.DetailExtraField1;
                VoucherType.DetailExtraField2 = voucher.DetailExtraField2;
                VoucherType.DetailExtraField3 = voucher.DetailExtraField3;
                VoucherType.DetailExtraField4 = voucher.DetailExtraField4;
                VoucherType.DetailExtraField5 = voucher.DetailExtraField5;

                VoucherType.MainValidationField1 = voucher.MainValidationField1;
                VoucherType.MainValidationField2 = voucher.MainValidationField2;
                VoucherType.mainValidationField3 = voucher.mainValidationField3;
                VoucherType.MainValidationField4 = voucher.MainValidationField4;
                VoucherType.MainValidationField5 = voucher.MainValidationField5;

                VoucherTypeList.Add(VoucherType);
            }
            return VoucherTypeList;
        }
        public static List<VoucherType> GetAllValidations()
        {
            List<VoucherType> VoucherValidationList = new List<VoucherType>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var VouchrsValidation = from val in newAppsCnn.Acc_VoucherValidation select val;
            foreach (var validation in VouchrsValidation)
            {
                VoucherType Vouchervalidation = new VoucherType();
                Vouchervalidation.VaidationID = validation.ValidationId;
                Vouchervalidation.ValidationArName = validation.ValidationName_Ara;
                Vouchervalidation.ValidationEnName = validation.ValidationName_Eng;
                VoucherValidationList.Add(Vouchervalidation);
            }
            return VoucherValidationList;
        }
        public static List<VoucherType> GetAllCurrency()
        {
            List<VoucherType> CurrencyList = new List<VoucherType>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var Currencys = from val in newAppsCnn.Acc_Currancy select val;
            foreach (var Currency in Currencys)
            {
                VoucherType CurrencyClass = new VoucherType();
                CurrencyClass.CurrencyID = Currency.CurrancyId;
                CurrencyClass.CurrencyArName = Currency.CurrancyName_Ara;
                CurrencyClass.CurrencyEnName = Currency.CurrancyName_Eng;
                CurrencyList.Add(CurrencyClass);
            }
            return CurrencyList;
        }

        public DataSaveResult Save(VoucherType _VoucherType)
        {

            try
            {
                Acc_VouchersType AccVouchersType;
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);

                AccVouchersType = newAppsCnn.Acc_VouchersType.Where(a => a.VoucherTypeId == _VoucherType.VoucherTypeId).FirstOrDefault();
                if (AccVouchersType != null)
                {
                    BuildDBRecord(AccVouchersType, _VoucherType);
                }

                else
                {

                    AccVouchersType = new Acc_VouchersType();
                    AccVouchersType = BuildDBRecord(AccVouchersType, _VoucherType);
                    newAppsCnn.Acc_VouchersType.Add(AccVouchersType);
                }


                newAppsCnn.SaveChanges();
                //   Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_VouchersType", this);

                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false };
            }
        }
        public DataDeleteResult Delete(string ID)
        {
            Acc_VouchersType AccVouchersType;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var VoucherType = from voucher in newAppsCnn.Acc_VouchersType where voucher.VoucherTypeId == ID select voucher;
                if (VoucherType.Count() > 0)
                {
                    AccVouchersType = VoucherType.First();
                    newAppsCnn.Acc_VouchersType.Remove(AccVouchersType);
                    newAppsCnn.SaveChanges();
                }
                return new DataDeleteResult() { DeleteStatus = true };
            }
            catch (Exception ex)
            {
                return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }

        private Acc_VouchersType BuildDBRecord(Acc_VouchersType _AccVouchersType, VoucherType _VoucherType)
        {
            _AccVouchersType.VoucherTypeId = _VoucherType.VoucherTypeId;
            _AccVouchersType.VoucherNmae_Eng = _VoucherType.VoucherEnName;
            _AccVouchersType.VoucherName_Ara = _VoucherType.VoucherArName;
            _AccVouchersType.ShortName_Ara = _VoucherType.ShortName_Ara;
            _AccVouchersType.ShortName_Eng = _VoucherType.ShortName_Eng;

            _AccVouchersType.CreditAccountid = _VoucherType.CriedtAccountID;
            _AccVouchersType.DepitAccountId = _VoucherType.DepitAccountId;
            _AccVouchersType.VoucherCurrancyid = _VoucherType.VoucherTypeCurrencyID;

            _AccVouchersType.MainExtraField1 = _VoucherType.MainExtraField1;
            _AccVouchersType.MainExtraField2 = _VoucherType.MainExtraField2;
            _AccVouchersType.MainExtraField3 = _VoucherType.MainExtraField3;
            _AccVouchersType.MainExtraField4 = _VoucherType.MainExtraField4;
            _AccVouchersType.MainExtraField5 = _VoucherType.MainExtraField5;

            _AccVouchersType.DetailExtraField1 = _VoucherType.DetailExtraField1;
            _AccVouchersType.DetailExtraField2 = _VoucherType.DetailExtraField2;
            _AccVouchersType.DetailExtraField3 = _VoucherType.DetailExtraField3;
            _AccVouchersType.DetailExtraField4 = _VoucherType.DetailExtraField4;
            _AccVouchersType.DetailExtraField5 = _VoucherType.DetailExtraField5;

            _AccVouchersType.MainValidationField1 = _VoucherType.MainValidationField1;
            _AccVouchersType.MainValidationField2 = _VoucherType.MainValidationField2;
            _AccVouchersType.mainValidationField3 = _VoucherType.mainValidationField3;
            _AccVouchersType.MainValidationField4 = _VoucherType.MainValidationField4;
            _AccVouchersType.MainValidationField5 = _VoucherType.MainValidationField5;
            return _AccVouchersType;
        }

        public int GetMaxId()
        {
           return int.Parse(DBContext.Acc_VouchersType.OrderByDescending(item => item.VoucherTypeId).First().VoucherTypeId);

        }
    }
    //public class Gidlist
    //{

    //    public string VoucherArName { get; set; }
    //    public string VoucherEnName { get; set; }
    //    public string ShortName_Ara { get; set; }
    //    public string ShortName_Eng { get; set; }
    //}
}
