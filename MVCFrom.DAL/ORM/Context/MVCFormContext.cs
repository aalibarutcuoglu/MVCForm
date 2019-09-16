using MVCFrom.DAL.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrom.DAL.ORM.Context
{
    public class MVCFormContext : DbContext
    {
        public MVCFormContext()
        {
            Database.Connection.ConnectionString = "Server=ALI;Database=MVCForm;UID=sa;PWD=ahmetali001996";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<RootObject> RootObjects { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<WebUser> WebUsers { get; set; }

        public DbSet<AdminUser> AdminUsers { get; set; }

    }
}
