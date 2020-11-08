using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<ApplicationUser>();
            var adminRole = new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "管理者" };
            var adminUser = new ApplicationUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                UserName = "user1",
                DisplayUserName = "管理者user1",
                NormalizedUserName = "user1",
                Password = "P@ssw0rd",
                PasswordHash = hasher.HashPassword(null, "P@ssw0rd")
            };

            Createing(modelBuilder, adminRole, adminUser);

            var leaderRole = new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Leader", NormalizedName = "リーダー" };
            var leaderUser = new ApplicationUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb8", // primary key
                UserName = "user2",
                DisplayUserName = "リーダーuser2",
                NormalizedUserName = "user2",
                Password = "P@ssw0rd",
                PasswordHash = hasher.HashPassword(null, "P@ssw0rd")
            };
            Createing(modelBuilder, leaderRole, leaderUser);
            var normalRole = new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", Name = "Normal", NormalizedName = "一般" };
            var normalUser = new ApplicationUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb7", // primary key
                UserName = "user3",
                DisplayUserName = "一般user3",
                NormalizedUserName = "user3",
                Password = "P@ssw0rd",
                PasswordHash = hasher.HashPassword(null, "P@ssw0rd")
            };
            Createing(modelBuilder, normalRole, normalUser);

        }

        private void Createing(ModelBuilder modelBuilder, IdentityRole role, ApplicationUser applicationUser) 
        {
            modelBuilder.Entity<IdentityRole>().HasData(role);
            modelBuilder.Entity<ApplicationUser>().HasData(applicationUser);

            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = role.Id,
                    UserId = applicationUser.Id
                }
            );
        }
    }
}
