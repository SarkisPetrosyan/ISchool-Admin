using ISchool.DAL.Constants;
using ISchool.DAL.Context;
using ISchool.Models.Entities;
using ISchool.Models.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity.Migrations;
using System.Security.Claims;

namespace ISchool.DAL.Migration
{
    internal sealed class Configuration : DbMigrationsConfiguration<DbContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(DbContext context)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            rm.Create(new IdentityRole(Roles.Driver));
            rm.Create(new IdentityRole(Roles.Admin));

            var um = new UserManager<User>(new UserStore<User>(context));
            var user = new User
            {
                UserName = "admin@gmail.com",
                EmailConfirmed = true,
                Email = "admin@gmail.com"
            };

            um.Create(user, "password1");
            var currentUser = um.FindByEmail(user.Email);
            um.AddToRole(currentUser.Id, Roles.Admin);
            um.AddClaim(currentUser.Id, new Claim(ClaimTypes.Role, Roles.Admin));

            var adminPerson = new Person
            {
                IsDeleted = false,
                CreatedBy = 0,
                CreatedDt = DateTime.UtcNow,
                DateOfBirth = DateTime.UtcNow.AddYears(-21),
                Email = "admin@gmail.com",
                FirstName = "Admin",
                LastName = "Admin",
                Gender = Gender.Male,
                Phone = "123456789",
                UpdatedBy = 0,
                UpdatedDt = DateTime.UtcNow,
                UserId = user.Id
            };

            context.Persons.AddOrUpdate(adminPerson);
            context.SaveChanges();
        }
    }
}
