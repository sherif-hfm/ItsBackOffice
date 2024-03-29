﻿using BackOfficeBL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL
{
    public class AppInfo
    {
        private static User mCurrentUser = null;
        public static User CurrentUser { get { return mCurrentUser; } set { mCurrentUser = value; UpdateAuditCurrentUser(); } }

        private static FinancialYear mCurrentYear = null;
        public static FinancialYear CurrentYear { get { return mCurrentYear; } set { mCurrentYear = value; } }

        public static List<object> SystemVariables = new List<object>();
        public static string ApplicationUINamespace = "BackOfficeUI";

        private static void UpdateAuditCurrentUser()
        {
            BackOfficeDAL.DbAudit.CrUserID = mCurrentUser.UserID;
        }
    }
}
