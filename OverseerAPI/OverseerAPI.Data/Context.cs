using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OverseerAPI.Models.Project;
using OverseerAPI.Models.Team;
using OverseerAPI.Models.TimeEntry;
using OverseerAPI.Models.User;
using OverseerAPI.Models.WorkTimer;

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
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // Drops the database if models changes in OverseerAPI.Model
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
            //modelBuilder.Entity<TimeEntry>().HasOptional(o => o.Project).WithOptionalDependent().WillCascadeOnDelete(false);
            //modelBuilder.Entity<TimeEntry>().HasOptional(o => o.Team).WithOptionalDependent().WillCascadeOnDelete(false);
            //modelBuilder.Entity<WorkTimer>().HasOptional(o=>o.Team).WithOptionalDependent().WillCascadeOnDelete(false);
            
            // Sets tables to none pluralized table names.
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<User>();
            //modelBuilder.Entity<User>().HasOptional(a => a.AspNetUserId);
            //modelBuilder.Entity<TimeEntry>().HasRequired(o=>o.Users);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<WorkTimer> WorkTimers { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
