using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BackOfficeBL.Search
{
   public class ContextSearch
    {
        NewAppsCnn DBContext = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);

        public int SearchID { get; set; }
        public string SearchSQL { get { return GetSearchSQL(); } }
        public string SearchSQL_Ara { get; set; }
        public string SearchSQL_Eng { get; set; }
        public string SearchResultStyle { get { return GetSearchResultStyle(); } }
        public string SearchResultStyle_Ara { get; set; }
        public string SearchResultStyle_Eng { get; set; }
        public string ReturnFields { get; set; }


        public ContextSearch(int contextSearchId)
        {
            SearchID = contextSearchId;
            var searchItem = DBContext.Srch_ContextualSearch.Where(item => item.SearchID == contextSearchId).First();

            SearchSQL_Ara = searchItem.SearchSQL_Ara;
            SearchSQL_Eng = searchItem.SearchSQL_Eng;
            SearchResultStyle_Ara = searchItem.SearchResultStyle_Ara;
            SearchResultStyle_Eng = searchItem.SearchResultStyle_Eng;
            ReturnFields = searchItem.ReturnsFields;

            LoadResultGridColumnStyle();

        }

        public List<DataGridColumnStyle> ResultGridColumnStyle = new List<DataGridColumnStyle>();


        public DataTable ExecuteSearch(string ParameterValue)
        {
            DataTable result = DataUtils.ExecuteDataTable(AppSettings.CrAppSettings.NewAppsConnectionString, SearchSQL, new List<DataParameter> { new DataParameter { ParameterName = "param", ParameterValue = ParameterValue } });
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
    }



}
