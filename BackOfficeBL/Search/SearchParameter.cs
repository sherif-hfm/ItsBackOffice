using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;
using System.Globalization;
using System.Data;
namespace BackOfficeBL.Search
{
    public class SearchParameterProperties
    {
        public SearchMaster Search { get; set; }
        public int ParameterID { get; set; }
        public string ValuesKeys { get; set; }
        public string ConditionDataFields { get; set; }
        public string ConditionParameters { get; set; }
        public string ParameterText { get { return GetParameterText(); } }
        public string ParameterText_Ara { get; set; }
        public string ParameterText_Eng { get; set; }
        public string ParameterControl { get; set; }
        public int ParameterControlWidth { get; set; }
        public string ComperOrders { get; set; }
        public string ComboBoxSQL { get { return GetComboBoxSQL(); } }
        public string ComboBoxSQL_Ara { get; set; }
        public string ComboBoxSQL_Eng { get; set; }
        public string ComboBoxValueMembers { get; set; }
        public string ComboBoxDisplayMember { get { return GetComboBoxDisplayMember(); } }
        public string ComboBoxDisplayMember_Ara { get; set; }
        public string ComboBoxDisplayMember_Eng { get; set; }
        public bool  BasedOnVariable { get; set; }
        public string SearchVariables { get; set; }
        public string DefaultValue { get; set; }

        public SearchParameterProperties()
        {
            
        }

        public void FromDbSearchParameter(Srch_SearchParameters _dbSearchParameter)
        {
            this.ParameterID = _dbSearchParameter.ParameterID;
            this.ValuesKeys = _dbSearchParameter.ValuesKeys;
            this.ConditionDataFields = _dbSearchParameter.ConditionDataFields;
            this.ConditionParameters = _dbSearchParameter.ConditionParameters;
            this.ParameterText_Ara = _dbSearchParameter.ParameterText_Ara;
            this.ParameterText_Eng = _dbSearchParameter.ParameterText_Eng;
            this.ParameterControl = _dbSearchParameter.ParameterControl;
            this.ParameterControlWidth = _dbSearchParameter.ParameterControlWidth;
            this.ComperOrders = _dbSearchParameter.ComperOrders;
            this.ComboBoxSQL_Ara = _dbSearchParameter.ComboBoxSQL_Ara;
            this.ComboBoxSQL_Eng = _dbSearchParameter.ComboBoxSQL_Eng;
            this.ComboBoxValueMembers = _dbSearchParameter.ComboBoxValueMembers;
            this.ComboBoxDisplayMember_Ara = _dbSearchParameter.ComboBoxDisplayMember_Ara;
            this.ComboBoxDisplayMember_Eng = _dbSearchParameter.ComboBoxDisplayMember_Eng;
        }

        private string GetParameterText()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.ParameterText_Eng;
                case "ar-KW":
                    return this.ParameterText_Ara;
                default:
                    return this.ParameterText_Eng;
            }
        }

        private string GetComboBoxSQL()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.ComboBoxSQL_Eng;
                case "ar-KW":
                    return this.ComboBoxSQL_Ara;
                default:
                    return this.ComboBoxSQL_Eng;
            }
        }

        private string GetComboBoxDisplayMember()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.ComboBoxDisplayMember_Eng;
                case "ar-KW":
                    return this.ComboBoxDisplayMember_Ara;
                default:
                    return this.ComboBoxDisplayMember_Eng;
            }
        }

        public DataTable GetComboData()
        {
            if (string.IsNullOrEmpty(this.ComboBoxSQL) == false)
            {
                DataTable result = DataUtils.ExecuteDataTable(AppSettings.CrAppSettings.NewAppsConnectionString, this.ComboBoxSQL);
                return result;
            }
            else
                return new DataTable("Tab1");
        }

    }

    
}
