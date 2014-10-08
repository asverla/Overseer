using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OverseerAPI.Data
{
    public class Context : DbContext
    {
        public Context()
            : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Drops the database if models changes in OverseerAPI.Model
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            // Sets tables to none pluralized table names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
