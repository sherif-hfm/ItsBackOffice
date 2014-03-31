using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BackOfficeDAL;
namespace BackOfficeBL.Security
{
    public class FormFunction
    {
        public int FunctionID { get; set; }
        public string FunctionText { get { return GetFunctionText(); } }
        public string FunctionText_Ara { get; set; }
        public string FunctionText_Eng { get; set; }

        public static List<FormFunction> GetFormFunctions()
        {
            List<FormFunction> result = new List<FormFunction>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbFormFunctions = from f in newAppsCnn.Sec_FormFunctions select f;
            foreach (var dbFormFunction in dbFormFunctions)
            {
                FormFunction formFunction = new FormFunction();
                formFunction.FromDbFormFunction(dbFormFunction);
                result.Add(formFunction);
            }
            return result;
        }

        private string GetFunctionText()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.FunctionText_Eng;
                case "ar-KW":
                    return this.FunctionText_Ara;
                default:
                    return this.FunctionText_Eng;
            }
        }

        public void FromDbFormFunction(Sec_FormFunctions _dbFormFunction)
        {
            this.FunctionID = _dbFormFunction.FunctionID;
            this.FunctionText_Ara = _dbFormFunction.FunctionText_Ara;
            this.FunctionText_Eng = _dbFormFunction.FunctionText_Eng;
        }
    }
}
