using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OverseerAPI.Models.Project;
using OverseerAPI.Models.Team;
using OverseerAPI.Models.User;

namespace OverseerAPI.Data
{
    public class IdentityDropCreateInitializer : CreateDatabaseIfNotExists<IdentityContext>
    {
        protected override void Seed(IdentityContext context)
        {
            //Seed identity tables here
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var appUser = new ApplicationUser { UserName = "test@standout.se", Email = "test@standout.se" };

            userManager.Create(appUser, "password");
            roleManager.Create(new IdentityRole { Name = "Kung" });
            userManager.AddToRole(appUser.Id, "Kung");

        }
    }

    public class DropCreateInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {

            var user = new User()
            {
                AspNetUserId = "0",
                FirstName = "Test",
                LastName = "Daaa",
                ApiKey = "?",
                AuthCode = "asdas",
                AvatarColor = "#FFFF",
                Username = "test@standout.se",
                Initials = "HA",
                Settings = "Vad?",
                InitialsColor = "#FFFFF"
            };

            context.Entry(user).State = EntityState.Added;
            context.SaveChanges();

            if (context.Set<User>().Any() && !context.Set<Team>().Any())
            {
                var team = new Team
                {
                    Name = "Standout",
                    Subdomain = "standout",
                    HourlyRate = 800,
                    ExpectedDailyHours = 8,
                    EncryptionKey = "hemlig",
                    FortnoxApiKey = "hemlig",
                    FortnoxDb = "EttNamn",
                    Settings = "Vad?",
                    CurrencyCode = "SEK"
                };

                context.Entry(team).State = EntityState.Added;
                context.SaveChanges();

                var teamMember = new TeamMember()
                {
                    TeamId = 1,
                    HourlyRate = 800,
                    Settings = "What?",
                    Active = true,
                    SalaryType = "Mucket pengi",
                    Phone = "0706380129",
                    CostPerWorkUnit = 10,
                    ExpectedDailyHours = 100,
                    InternalHourlyRate = 100,
                    TeamRole = "MANAGER",
                    UserId = 1,
                };

                context.Entry(teamMember).State = EntityState.Added;

                context.SaveChanges();

                var project = new Project
                {
                    TeamId = 1,
                    Title = "Overseer",
                    Description = "Build a better Overseer",
                    TotalApprovedTime = 40,
                    AlreadyInvoicedAmount = 500,
                    AlreadyInvoicedSeconds = 0,
                    Budget = 10000,
                    Chargeable = true,
                    Charging = "What?",
                    PayPerHour = true,
                    Status = 1,
                    EstimatedHours = 8000,
                    TotalTime = 10000,
                    HourlyRate = 800,
                    EarliestStart = DateTime.Now,
                    Deadline = DateTime.Now.AddDays(7),
                    VatPercentage = 2.5,
                    ProjectType = "??"
                };

                context.Entry(project).State = EntityState.Added;

                context.SaveChanges();
            }
        }
    }
}
