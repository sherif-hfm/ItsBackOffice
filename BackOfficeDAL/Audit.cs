using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading;

namespace BackOfficeDAL
{
    public static class DbAudit
    {
        public enum AuditActionTypes { AddNew = 1, Edit = 2, Delete = 3 };
        public static string NewAppsConnectionString = "";
        public static int CrUserID;

        public static void AddDataAudit(List<DbEntityEntry> _auditData)
        {
            Thread addAutid = new Thread(() => AddDataAuditAsync(_auditData));
            addAutid.Start();
        }

        private static void AddDataAuditAsync(List<DbEntityEntry> _auditData)
        {
            NewAppsCnn cnn = new NewAppsCnn(NewAppsConnectionString);
            foreach (DbEntityEntry entity in _auditData)
            {
                string tableName = entity.Entity.GetType().BaseType.Name;
                if (!(entity.Entity is Grnl_Audit) && !(entity.Entity is Grnl_AuditDtl) && !(entity.Entity is Gnrl_AuditActions))
                {
                    Grnl_Audit audit = new Grnl_Audit();
                    audit.TableName = tableName;
                    audit.UserId = CrUserID;
                    audit.AuditActionId = (int)entity.State;
                    audit.ActionDate = DateTime.Now;
                    string[] propertyNames;
                    switch (entity.State)
                    {
                        case System.Data.EntityState.Added:
                            propertyNames = entity.CurrentValues.PropertyNames.ToArray();
                            break;
                        case System.Data.EntityState.Deleted:
                            propertyNames = entity.OriginalValues.PropertyNames.ToArray();
                            break;
                        default:
                            propertyNames = entity.CurrentValues.PropertyNames.ToArray();
                            break;
                    }

                    foreach (var propertyName in propertyNames)
                    {
                        Grnl_AuditDtl auditDtl = new Grnl_AuditDtl();
                        auditDtl.PropertyName = propertyName;
                        switch (entity.State)
                        {
                            case System.Data.EntityState.Added:
                                if (entity.CurrentValues[propertyName] != null)
                                    auditDtl.PropertyCurrentValues = entity.CurrentValues[propertyName].ToString();
                                break;
                            case System.Data.EntityState.Modified:
                                auditDtl.PropertyCurrentValues = entity.CurrentValues[propertyName].ToString();
                                auditDtl.PropertyOriginalValues = entity.OriginalValues[propertyName].ToString();
                                break;
                            case System.Data.EntityState.Deleted:
                                auditDtl.PropertyOriginalValues = entity.OriginalValues[propertyName].ToString();
                                break;
                            default:
                                auditDtl.PropertyCurrentValues = entity.CurrentValues[propertyName].ToString();
                                break;
                        }
                        if(!string.IsNullOrEmpty(auditDtl.PropertyCurrentValues))
                        audit.Grnl_AuditDtl.Add(auditDtl);
                    }
                    cnn.Grnl_Audit.Add(audit);
                    cnn.SaveChanges();
                }
            }
        }


    }
}
