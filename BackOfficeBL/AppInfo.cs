using BackOfficeBL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL
{
    public  class AppInfo
    {
        public static User CurrentUser;
        public static List<object> SystemVariables = new List<object>();
        public static string ApplicationUINamespace = "BackOfficeUI";
    }
}
