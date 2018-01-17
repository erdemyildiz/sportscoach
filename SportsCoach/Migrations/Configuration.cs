namespace SportsCoach.Migrations
{
    using DAL;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsCoach.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SportsCoach.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region CreateRoles
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole() { Name = "Admin" });
            #endregion

            if (context.Users.Count() == 0)
            {
                #region CreateUsers
                UserStore<IdentityUser> us = new UserStore<IdentityUser>(new SportsCoachContext());
                UserManager<IdentityUser> um = new UserManager<IdentityUser>(us);

                IdentityUser user1 = new IdentityUser();
                user1.Email = "admin@erp2blog.com";
                user1.UserName = "admin@erp2blog.com";

                IdentityUser user2 = new IdentityUser();
                user2.Email = "author@erp2blog.com";
                user2.UserName = "author@erp2blog.com";

                IdentityUser user3 = new IdentityUser();
                user3.Email = "demo@erp2blog.com";
                user3.UserName = "demo@erp2blog.com";

                um.Create(user1, "Aa123456!");
                um.Create(user2, "Aa123456!");
                um.Create(user3, "Aa123456!");
                #endregion
                #region AssignUsersToRoles
                um.AddToRole(user1.Id, "Admin");
                um.AddToRole(user2.Id, "Author");
                #endregion
            }




        }
    }
}
