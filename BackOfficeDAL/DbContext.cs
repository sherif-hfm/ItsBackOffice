using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace BackOfficeDAL
{
    public partial class NewAppsCnn : DbContext
    {
        public NewAppsCnn(string _connectionString)
        {
            Database.Connection.ConnectionString = _connectionString;
            NewAppsCnn newAppsCnn = new NewAppsCnn();
        }

        public override int SaveChanges()
        {
            List<DbEntityEntry> changes = ChangeTracker.Entries().ToList();
            DbAudit.AddDataAudit(changes);
            return  base.SaveChanges();
        }
        
    }
}
