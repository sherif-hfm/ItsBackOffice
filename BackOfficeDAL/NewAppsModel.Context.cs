﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackOfficeDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewAppsCnn : DbContext
    {
        public NewAppsCnn()
            : base("name=NewAppsCnn")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Sec_FormFunctions> Sec_FormFunctions { get; set; }
        public DbSet<Sec_GroupRights> Sec_GroupRights { get; set; }
        public DbSet<Sec_Groups> Sec_Groups { get; set; }
        public DbSet<Sec_MainMenu> Sec_MainMenu { get; set; }
        public DbSet<Sec_Users> Sec_Users { get; set; }
        public DbSet<Srch_SearchMaster> Srch_SearchMaster { get; set; }
        public DbSet<Srch_SearchParameters> Srch_SearchParameters { get; set; }
        public DbSet<Acc_AccountCategory> Acc_AccountCategory { get; set; }
        public DbSet<Acc_Accounts> Acc_Accounts { get; set; }
        public DbSet<Acc_Accountype> Acc_Accountype { get; set; }
    }
}
