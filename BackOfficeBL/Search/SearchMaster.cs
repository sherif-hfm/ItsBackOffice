using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackOfficeDAL;
using System.Globalization;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
namespace BackOfficeBL.Search
{
    public class SearchMaster
    {
        public int SearchID { get; set; }
        public string SearchSQL { get { return GetSearchSQL(); } }
        public string SearchSQL_Ara { get; set; }
        public string SearchSQL_Eng { get; set; }
        public string SearchResultStyle { get { return GetSearchResultStyle(); } }
        public string SearchResultStyle_Ara { get; set; }
        public string SearchResultStyle_Eng { get; set; }
        public bool AddWhere { get; set; }
        public int ParametersColumns { get; set; }
        public string ReturnsFields { get; set; }
        public string AddNewForm { get; set; }
        public string EditForm { get; set; }
        public List<SearchParameterProperties> SearchParametersProperties = new List<SearchParameterProperties>();
        public string FullSearchSQL { get; set; }
        public Dictionary<string, object> DataParameters = new Dictionary<string, object>();
        public List<DataGridColumnStyle> ResultGridColumnStyle = new List<DataGridColumnStyle>();
        
        public SearchMaster(int _searchID)
        {
            SearchID = _searchID;
        }

        public void Load()
        {
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbSearchMasters = from s in newAppsCnn.Srch_SearchMaster where s.SearchID == this.SearchID select s;
            if (dbSearchMasters.Count() > 0)
            {
                this.FromDbSearchMaster(dbSearchMasters.First());
                LoadResultGridColumnStyle();
                SaveResultGridColumnStyle();
                LoadDbSearchParameters(dbSearchMasters.First());
            }
        }

        public void FromDbSearchMaster(Srch_SearchMaster _searchMaster)
        {
            this.SearchID = _searchMaster.SearchID;
            this.SearchSQL_Ara = _searchMaster.SearchSQL_Ara;
            this.SearchSQL_Eng = _searchMaster.SearchSQL_Eng;
            this.SearchResultStyle_Ara = _searchMaster.SearchResultStyle_Ara;
            this.SearchResultStyle_Eng = _searchMaster.SearchResultStyle_Eng;
            this.AddWhere = _searchMaster.AddWhere;
            this.ParametersColumns = _searchMaster.ParametersColumns;
            this.ReturnsFields = _searchMaster.ReturnsFields;
            this.AddNewForm = _searchMaster.AddNewForm;
            this.EditForm = _searchMaster.EditForm;
        }

        public void LoadDbSearchParameters(Srch_SearchMaster _searchMaster)
        {
            foreach (var dbSearchParameter in _searchMaster.Srch_SearchParameters)
            {
                SearchParameterProperties searchParameter = new SearchParameterProperties();
                searchParameter.Search = this;
                searchParameter.FromDbSearchParameter(dbSearchParameter);
                this.SearchParametersProperties.Add(searchParameter);
            }
        }

        private string GetSearchResultStyle()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.SearchResultStyle_Eng;
                case "ar-KW":
                    return this.SearchResultStyle_Ara;
                default:
                    return this.SearchResultStyle_Eng;
            }
        }

        private string GetSearchSQL()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.SearchSQL_Eng;
                case "ar-KW":
                    return this.SearchSQL_Ara;
                default:
                    return this.SearchSQL_Eng;
            }
        }

        public DataTable ExecuteSearch()
        {
            var dataPrms = from p in this.DataParameters select new BackOfficeDAL.DataParameter { ParameterName = p.Key, ParameterValue = p.Value };
            DataTable result = DataUtils.ExecuteDataTable(AppSettings.CrAppSettings.NewAppsConnectionString, this.FullSearchSQL, dataPrms.ToList());
            return result;
        }

        public void LoadResultGridColumnStyle()
        {
            try
            {
                TextReader strReader = new StringReader(SearchResultStyle);
                XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(ResultGridColumnStyle.GetType(), new XmlRootAttribute("ResultGridColumnStyle"));
                ResultGridColumnStyle = (List<DataGridColumnStyle>)reader.Deserialize(strReader);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void SaveResultGridColumnStyle()
        {
            try
            {
                StringWriter strWriter = new StringWriter();
                StreamWriter file = new System.IO.StreamWriter(@"D:\Settings.xml");
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
                {
                    Encoding = Encoding.Unicode,
                    OmitXmlDeclaration = true,
                    Indent = true
                };
                XmlWriter xmlWriter = XmlWriter.Create(file, xmlWriterSettings);
                XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(ResultGridColumnStyle.GetType(), new XmlRootAttribute("ResultGridColumnStyle"));
                writer.Serialize(xmlWriter, ResultGridColumnStyle);
                file.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    [Serializable]
    public class DataGridColumnStyle
    {
        public enum ColumnTypeEnum { TextBoxColumn = 1, CheckBoxColumn = 2 };
        public string Name { get; set; }
        public string HeaderText { get { return GetHeaderText(); } }
        public string HeaderText_Ara { get; set; }
        public string HeaderText_Eng { get; set; }
        public string DataPropertyName { get { return GetDataPropertyName(); } }
        public string DataPropertyName_Ara { get; set; }
        public string DataPropertyName_Eng { get; set; }
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }
        public ColumnTypeEnum ColumnType { get; set; }

        private string GetHeaderText()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.HeaderText_Eng;
                case "ar-KW":
                    return this.HeaderText_Ara;
                default:
                    return this.HeaderText_Eng;
            }
        }

        private string GetDataPropertyName()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.DataPropertyName_Eng;
                case "ar-KW":
                    return this.DataPropertyName_Ara;
                default:
                    return this.DataPropertyName_Eng;
            }
        }
    }
}
