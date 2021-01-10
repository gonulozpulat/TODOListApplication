using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Dal.Concrete.Framework.EntityFramework.FluentMapping;

namespace TODOList.Dal.Concrete.Framework.EntityFramework
{
    public class TODOListContext : DbContext
    {
        public TODOListContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Database.Connection.ConnectionString = @"Server=CASPERNIRVANA\SQLEXPRESS;Database=TODOList;User Id=gonul; Password = 123;";
            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<TODOList.Entities.Concrete.Task> Task { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new MapTask());
        }

    }
}
