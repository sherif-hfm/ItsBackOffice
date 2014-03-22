using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using BackOfficeDAL;
using System.Threading;
using System.Data.Entity.Infrastructure;
namespace BackOfficeAudit
{
    public static class Audit
    {
        public enum AuditActionTypes { AddNew = 1, Edit = 2, Delete = 3 };

        public static void AddDataAudit(List<DbEntityEntry> _auditData)
        {
            Thread addAutid = new Thread(() => AddDataAuditAsync(_auditData));
            addAutid.Start();
        }

        private static void AddDataAuditAsync(List<DbEntityEntry> _auditData)
        { 
        
        }

        private static string GetXml(object _auditData)
        {
            StringWriter strWriter = new StringWriter();
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                Encoding = Encoding.Unicode,
                OmitXmlDeclaration = true,
                Indent = true,
                 NewLineOnAttributes =true
            };
            XmlWriter xmlWriter = XmlWriter.Create(strWriter, xmlWriterSettings);
            XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(_auditData.GetType(), new XmlRootAttribute("AuditData"));

            writer.Serialize(xmlWriter, _auditData);
            return strWriter.GetStringBuilder().ToString();
        }
    }
}
