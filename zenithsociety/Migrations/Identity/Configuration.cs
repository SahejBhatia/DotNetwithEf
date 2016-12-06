namespace zenithsociety.Migrations.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<zenithsociety.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(zenithsociety.Models.ApplicationDbContext context)
        {

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Administrator"))
                roleManager.Create(new IdentityRole("Administrator"));

            if (!roleManager.RoleExists("Member"))
                roleManager.Create(new IdentityRole("Member"));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            string[] emails = { "a@a.a", "m@m.c" };
            string[] usernames = { "a", "b" };

            if (userManager.FindByEmail(emails[0]) == null)
            {
                var user = new ApplicationUser
                {
                    Email = emails[0],
                    UserName = usernames[0],
                };
                var result = userManager.Create(user, "P@$$w0rd");

                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Administrator");
            }
            if (userManager.FindByEmail(emails[1]) == null)
            {
                var user = new ApplicationUser
                {
                    Email = emails[1],
                    UserName = usernames[1],
                };
                var result = userManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Member");
            }
        }

    }
}