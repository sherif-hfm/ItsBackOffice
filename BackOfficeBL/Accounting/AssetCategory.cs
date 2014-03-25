using BackOfficeAudit;
using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public class AssetCatogry
    {
        public int AstCatId { get; set; }
        public string Name { get { return GetAssetCatogryName(); } }
        public string AstCatName_Ara { get; set; }
        public string AstCatName_Eng { get; set; }
        public bool IsDisable { get; set; }
        public int? ParentId { get; set; }
        public bool IsNew { get; set; }



        private static int getNodeLevel(int IntCount, int? AstCatId)
        {
            var CurrAssetCatogry = FindByAstCatId(AstCatId);
            if (CurrAssetCatogry == null)
            {
                return IntCount;
            }
            else if (CurrAssetCatogry.ParentId == null )
            {
                return ++IntCount;
            }
            else
            {
                return getNodeLevel(++IntCount, CurrAssetCatogry.ParentId);
            }
        }

        public static List<AssetCatogry> GetAllAssetCatogryTree()
        {
            List<AssetCatogry> result = new List<AssetCatogry>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAssetCatogrys = from g in newAppsCnn.Ast_AssetCatogry select g;
            foreach (var dbAssetCatogry in dbAssetCatogrys)
            {
                AssetCatogry account = new AssetCatogry();
                account.FromDbAssetCatogry(dbAssetCatogry);
                result.Add(account);
            }
            return result;
        }

        public static List<AssetCatogry> GetAllCmbAssetCatogry()
        {
            List<AssetCatogry> result = new List<AssetCatogry>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAssetCatogrys = from g in newAppsCnn.Ast_AssetCatogry where g.IsDisable==false select g;
            foreach (var dbAssetCatogry in dbAssetCatogrys)
            {
                AssetCatogry account = new AssetCatogry();
                account.FromDbAssetCatogry(dbAssetCatogry);
                result.Add(account);
            }
            return result;
        }
        public static AssetCatogry FindByAstCatId(int? _VaidationID)
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbAssetCatogrys = from u in newAppsCnn.Ast_AssetCatogry where u.AstCatId == _VaidationID select u;
            if (dbAssetCatogrys.Count() > 0)
            {
                Ast_AssetCatogry dbAssetCatogry = dbAssetCatogrys.First();
                AssetCatogry account = new AssetCatogry();
                account.FromDbAssetCatogry(dbAssetCatogry);
                account.IsNew = false;
                return account;
            }
            else
                return null;
        }
        public AssetCatogry()
        {
            this.IsNew = true;
        }

        private string GetAssetCatogryNameAndNo()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.AstCatName_Eng + " - " + this.AstCatId;
                case "ar-KW":
                    return this.AstCatName_Ara + " - " + this.AstCatId;
                default:
                    return this.AstCatName_Eng + " - " + this.AstCatId;
            }
        }

        private string GetAssetCatogryName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.AstCatName_Eng;
                case "ar-KW":
                    return this.AstCatName_Ara;
                default:
                    return this.AstCatName_Eng;
            }
        }

        public void FromDbAssetCatogry(Ast_AssetCatogry _dbAssetCatogry)
        {
            this.AstCatId = _dbAssetCatogry.AstCatId;
            this.AstCatName_Ara = _dbAssetCatogry.AstCatName_Ara;
            this.AstCatName_Eng = _dbAssetCatogry.AstCatName_Eng;
            this.IsDisable = _dbAssetCatogry.IsDisable;
            this.ParentId = _dbAssetCatogry.ParentId;
            this.IsNew = false;
        }

        public void ToDbAssetCatogry(Ast_AssetCatogry _dbAssetCatogry)
        {
            _dbAssetCatogry.AstCatId = this.AstCatId;
            _dbAssetCatogry.AstCatName_Ara = this.AstCatName_Ara;
            _dbAssetCatogry.AstCatName_Eng = this.AstCatName_Eng;
            _dbAssetCatogry.IsDisable = this.IsDisable;
            if (this.IsNew == true)
            {
                _dbAssetCatogry.ParentId = this.ParentId;
            }
        }

        public DataSaveResult Save()
        {
            Ast_AssetCatogry dbAssetCatogry;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAssetCatogrys = from u in newAppsCnn.Ast_AssetCatogry where u.AstCatId == this.AstCatId select u;
                if (dbAssetCatogrys.Count() > 0)
                {
                    dbAssetCatogry = dbAssetCatogrys.First();
                    this.ToDbAssetCatogry(dbAssetCatogry);
                }
                else
                {
                    dbAssetCatogry = new Ast_AssetCatogry();
                    this.ToDbAssetCatogry(dbAssetCatogry);
                    newAppsCnn.Ast_AssetCatogry.Add(dbAssetCatogry);
                }
                newAppsCnn.SaveChanges();
                Audit.AddDataAudit(Audit.AuditActionTypes.AddNew, "Ast_AssetCatogry", this);
                this.FromDbAssetCatogry(dbAssetCatogry);
                return new DataSaveResult() { SaveStatus = true };
            }
            catch (Exception ex)
            {
                return new DataSaveResult() { SaveStatus = false };
            }
        }

        public DataDeleteResult Delete()
        {
            Ast_AssetCatogry dbAssetCatogry;
            try
            {
                NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
                var dbAssetCatogrys = from u in newAppsCnn.Ast_AssetCatogry where u.AstCatId == this.AstCatId select u;
                if (dbAssetCatogrys.Count() > 0)
                {
                    dbAssetCatogry = dbAssetCatogrys.First();
                    newAppsCnn.Ast_AssetCatogry.Remove(dbAssetCatogry);
                    newAppsCnn.SaveChanges();
                }
                return new DataDeleteResult() { DeleteStatus = true };
            }
            catch (Exception ex)
            {
                return new DataDeleteResult() { DeleteStatus = false, ErrorMessage = ex.Message };
            }
        }

    }
}
