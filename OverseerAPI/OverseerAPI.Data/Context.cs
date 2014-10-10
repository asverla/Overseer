using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OverseerAPI.Models.TimeEntry;
using OverseerAPI.Models.User;

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
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<User>().HasOptional(s => s.Team);
            //modelBuilder.Entity<User>().HasOptional(a => a.AspNetUserId);
            modelBuilder.Entity<TimeEntry>().ToTable("TimeEntries");
        }
    }
}
