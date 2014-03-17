using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}
