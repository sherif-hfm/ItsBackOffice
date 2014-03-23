using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeAudit;
using BackOfficeDAL;

namespace BackOfficeBL.Accounting
{
    public class Voucher
    {

        public static List<VoucherType> GetAllVouchers()
        {
            List<VoucherType> VoucherTypeList = new List<VoucherType>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var VouchrsType = from type in newAppsCnn.Acc_VouchersType select type;
            foreach (var voucher in VouchrsType)
            {
                VoucherType vt = new VoucherType();
                vt.VoucherTypeId = voucher.VoucherTypeId;
                vt.VoucherEnName = voucher.VoucherNmae_Eng;
                vt.VoucherArName = voucher.VoucherName_Ara;
                vt.ShortName_Ara = voucher.ShortName_Ara;
                vt.ShortName_Eng = voucher.ShortName_Eng;

                vt.CriedtAccountID = voucher.CreditAccountid;
                vt.DepitAccountId = voucher.DepitAccountId;
                vt.CurrencyID = Convert.ToInt32(voucher.VoucherCurrancyid);

                vt.MainExtraField1 = voucher.MainExtraField1;
                vt.MainExtraField2 = voucher.MainExtraField2;
                vt.MainExtraField3 = voucher.MainExtraField3;
                vt.MainExtraField4 = voucher.MainExtraField4;
                vt.MainExtraField5 = voucher.MainExtraField5;

                vt.DetailExtraField1 = voucher.DetailExtraField1;
                vt.DetailExtraField2 = voucher.DetailExtraField2;
                vt.DetailExtraField3 = voucher.DetailExtraField3;
                vt.DetailExtraField4 = voucher.DetailExtraField4;
                vt.DetailExtraField5 = voucher.DetailExtraField5;

                vt.MainValidationField1 = voucher.MainValidationField1;
                vt.MainValidationField2 = voucher.MainValidationField2;
                vt.mainValidationField3 = voucher.mainValidationField3;
                vt.MainValidationField4 = voucher.MainValidationField4;
                vt.MainValidationField5 = Convert.ToInt32(voucher.MainValidationField5);

                VoucherTypeList.Add(vt);
            }
            return VoucherTypeList;
        }
        public static List<VoucherValidation> GetAllValidations()
        {
            List<VoucherValidation> VoucherValidationList = new List<VoucherValidation>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var VouchrsValidation = from val in newAppsCnn.Acc_VoucherValidation select val;
            foreach (var validation in VouchrsValidation)
            {
                VoucherValidation valid = new VoucherValidation();
                valid.VaidationID = validation.ValidationId;
                valid.ValidationArName = validation.ValidationName_Ara;
                valid.ValidationEnName = validation.ValidationName_Eng;
                VoucherValidationList.Add(valid);
            }
            return VoucherValidationList;
        }
        public static List<Currency> GetAllCurrency()
        {
            List<Currency> CurrencyList = new List<Currency>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var Currency = from val in newAppsCnn.Acc_Currancy select val;
            foreach (var Cur in Currency)
            {
                Currency CurrencyCla = new Currency();
                CurrencyCla.CurrencyID = Cur.CurrancyId;
                CurrencyCla.CurrencyArName = Cur.CurrancyName_Ara;
                CurrencyCla.CurrencyEnName = Cur.CurrancyName_Eng;
                CurrencyList.Add(CurrencyCla);
            }
            return CurrencyList;
        }
        public DataSaveResult Save(VoucherType _Voucher)
        {

            try
            {
                Acc_VouchersType AccVouchersType;
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                if (_Voucher.VoucherTypeId != "")
                {
                    AccVouchersType = newAppsCnn.Acc_VouchersType.Where(a => a.VoucherTypeId == _Voucher.VoucherTypeId).ToList().FirstOrDefault();
                    if (AccVouchersType != null)
                    {
                        AccVouchersType = BuildDBRecord(AccVouchersType, _Voucher);
                        newAppsCnn.Acc_VouchersType.Add(AccVouchersType);
                    }
                }
                else
                {
                    AccVouchersType = new Acc_VouchersType();

                    AccVouchersType = BuildDBRecord(AccVouchersType, _Voucher);
                    newAppsCnn.Acc_VouchersType.Add(AccVouchersType);
                }


                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Acc_VouchersType", this);

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
                var q = from voucher in newAppsCnn.Acc_VouchersType where voucher.VoucherTypeId == ID select voucher;
                if (q.Count() > 0)
                {
                    AccVouchersType = q.First();
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
            _AccVouchersType.VoucherCurrancyid = _VoucherType.CurrencyID;

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
            _AccVouchersType.MainValidationField5 = _VoucherType.MainValidationField5.ToString();
            return _AccVouchersType;
        }
    }
}
