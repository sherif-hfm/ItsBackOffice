using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Accounting
{
    public static class TableSequence
    {
        static NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);

        public static string GetLastId(string TableName, string Year, string locationId)
        {
            var Items = newAppsCnn.Gnrl_TableSequence.Where(item => (item.TableName == TableName && item.UniqueYear == Year)).ToList();
            if (Items.Count() > 0)
            {
                var ZerosFormat = string.Empty;
                for (int i = 0; i < Items.First().SerialSize; i++)
                {
                    ZerosFormat += "0";
                }
                return AppInfo.CurrentYear.EndDate.Year + (Items.First().CurrentValue + 1).ToString(ZerosFormat);
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
