using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                vt.VoucherTypeId = Convert.ToInt32(voucher.VoucherTypeId);
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
            }
            return VoucherValidationList;
        }

    }
}
