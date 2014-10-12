using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using OverseerAPI.Models.User;

namespace OverseerAPI.Data
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Database.CreateIfNotExists();
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
