using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BackOfficeDAL
{
    public class DataUtils
    {
        public static DataTable ExecuteDataTable(string _cnnStr,string _sql)
        {
            DataTable result=new DataTable("Tab1");
            SqlDataAdapter adpt = new SqlDataAdapter(_sql, _cnnStr);
            adpt.Fill(result);
            return result;
        }

        public static DataTable ExecuteDataTable(string _cnnStr, string _sql, List<DataParameter> _parameters)
        {
            DataTable result = new DataTable("Tab1");
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(_sql, _cnnStr);
                foreach (var prm in _parameters)
                {
                    if (_sql.Contains("@" + prm.ParameterName) == true)
                    {
                        SqlParameter sqlPrm = new SqlParameter(prm.ParameterName, "%"+prm.ParameterValue+"%");
                        adpt.SelectCommand.Parameters.Add(sqlPrm);
                    }
                }
                adpt.Fill(result);
            }
            catch (Exception)
            {
                
            }
            return result;

        }
    }

    public class DataParameter
    {
        public string ParameterName { get; set; }
        public object ParameterValue { get; set; }
    }
}
