using BackOfficeBL.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BackOfficeBL
{
    public class AppSettings
    {
        public string NewAppsConnectionString = "Data Source=madaz.zapto.org;initial catalog=BackOffice;persist security info=True;user id=BackOffice;password=BackOfficeadmin;MultipleActiveResultSets=True;Application Name=EntityFramework";
       // public string NewAppsConnectionString = @"Data Source=VS2012-PC\SQLSRV2008R2;initial catalog=NewApps;persist security info=True;user id=sa;password=P@ssw0rd;MultipleActiveResultSets=True;Application Name=EntityFramework";

        public static AppSettings CrAppSettings = new AppSettings();

        public AppSettings()
        {
            BackOfficeDAL.DbAudit.NewAppsConnectionString = this.NewAppsConnectionString;
        }

        public void LoadSettings()
        {
            try
            {
                AppSettings setting;
                XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(AppSettings), new XmlRootAttribute("NewAppsSettings"));
                System.IO.StreamReader file = new System.IO.StreamReader("Settings.xml");
                setting = (AppSettings)reader.Deserialize(file);
                file.Close();
                CrAppSettings = setting;
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }

        public void SaveSettings()
        {
            try
            {
                StringWriter strWriter = new StringWriter();
                StreamWriter file = new System.IO.StreamWriter("Settings.xml");
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
                {
                    Encoding = Encoding.Unicode,
                    OmitXmlDeclaration = true,
                    Indent = true
                };
                XmlWriter xmlWriter = XmlWriter.Create(file, xmlWriterSettings);
                XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(CrAppSettings.GetType(), new XmlRootAttribute("NewAppsSettings"));
                writer.Serialize(xmlWriter, CrAppSettings);
                file.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
