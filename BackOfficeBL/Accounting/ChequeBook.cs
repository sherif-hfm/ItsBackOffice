using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BackOfficeDAL;

namespace BackOfficeBL.Accounting
{
    public class ChequeBook
    {
        public int ChequeBookID { get; set; }
        public string CheuqeBookName_Ara { get; set; }
        public string CheuqeBookName_Eng { get; set; }
        public int ChequeCurrancyId { get; set; }
        public string BankAccountId { get; set; }
        public bool IsDisable { get; set; }
        public int ChequeStartNo { get; set; }
        public int CHequeEndno { get; set; }

        public string AccountId { get; set; }
        public string BankAccountName { get { return GetAccountName(); } }
        public string AccountName_Ar { get; set; }
        public string AccountName_En { get; set; }
        private string GetAccountName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.AccountName_En;
                case "ar-KW":
                    return this.AccountName_Ar;
                default:
                    return this.AccountName_En;
            }
        }


        public static List<ChequeBook> GetAllCheques()
        {
            List<ChequeBook> ChequeBookList = new List<ChequeBook>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var _ChequeBook = from Cheque in newAppsCnn.Acc_ChequeBook select Cheque;

            foreach (var chequebook in _ChequeBook)
            {
                ChequeBook chkbook = new ChequeBook();
                chkbook.ChequeBookID = chequebook.ChequeBookID;
                chkbook.CheuqeBookName_Ara = chequebook.CheuqeBookName_Ara;
                chkbook.CheuqeBookName_Eng = chequebook.CheuqeBookName_Eng;
                chkbook.ChequeStartNo = chequebook.ChequeStartNo;
                chkbook.CHequeEndno = chequebook.CHequeEndno;
                chkbook.IsDisable = chequebook.IsDisable;
                chkbook.ChequeCurrancyId = chequebook.ChequeCurrancyId;
                chkbook.BankAccountId = chequebook.BankAccountId;
                ChequeBookList.Add(chkbook);

            }
            return ChequeBookList;
        }

        public static List<ChequeBook> GetAllAccounts()
        {
            List<ChequeBook> ChequeBookList = new List<ChequeBook>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var _BankAccounts = from Cheque in newAppsCnn.Acc_Accounts.Where(a => a.AccountCategoryId == 1) select Cheque;

            foreach (var account in _BankAccounts)
            {
                ChequeBook bankaccount = new ChequeBook();
                bankaccount.AccountName_Ar = account.AccountName_Ar;
                bankaccount.AccountName_En = account.AccountName_Eng;
                bankaccount.AccountId = account.AccountID;
                ChequeBookList.Add(bankaccount);
            }
            return ChequeBookList;
        }

        public DataDeleteResult Delete(int ChequeID)
        {
            Acc_ChequeBook Acc_Cheque;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var ChequeBook = from Cheque in newAppsCnn.Acc_ChequeBook where Cheque.ChequeBookID == ChequeID select Cheque;
                if (ChequeBook.Count() > 0)
                {
                    Acc_Cheque = ChequeBook.First();
                    newAppsCnn.Acc_ChequeBook.Remove(Acc_Cheque);
                    newAppsCnn.SaveChanges();
                }
                return new DataDeleteResult() { DeleteStatus = true };
            }
            catch (Exception ex)
            {
                return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }
        public DataSaveResult Save(ChequeBook _ChequeBook)
        {

            try
            {
                Acc_ChequeBook Acc_ChequeBook;
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);

                Acc_ChequeBook = newAppsCnn.Acc_ChequeBook.Where(a => a.ChequeBookID == _ChequeBook.ChequeBookID).FirstOrDefault();
                if (Acc_ChequeBook != null)
                {
                    BuildDBRecord(Acc_ChequeBook, _ChequeBook);
                }

                else
                {

                    Acc_ChequeBook = new Acc_ChequeBook();
                    Acc_ChequeBook = BuildDBRecord(Acc_ChequeBook, _ChequeBook);
                    newAppsCnn.Acc_ChequeBook.Add(Acc_ChequeBook);
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

        private Acc_ChequeBook BuildDBRecord(Acc_ChequeBook _Acc_ChequeBook, ChequeBook _ChequeBook)
        {
            if (_ChequeBook.ChequeBookID != -1)
            {
                _Acc_ChequeBook.ChequeBookID = _ChequeBook.ChequeBookID;

            }
            _Acc_ChequeBook.CheuqeBookName_Ara = _ChequeBook.CheuqeBookName_Ara;
            _Acc_ChequeBook.CheuqeBookName_Eng = _ChequeBook.CheuqeBookName_Eng;
            _Acc_ChequeBook.ChequeStartNo = _ChequeBook.ChequeStartNo;
            _Acc_ChequeBook.CHequeEndno = _ChequeBook.CHequeEndno;
            _Acc_ChequeBook.IsDisable = _ChequeBook.IsDisable;
            _Acc_ChequeBook.BankAccountId = _ChequeBook.BankAccountId;
            _Acc_ChequeBook.ChequeCurrancyId = _ChequeBook.ChequeCurrancyId;
            return _Acc_ChequeBook;
        }


    }
}
