using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestLaab1.Models;

namespace Models
{
    public class ContextDb : DbContext
    {
        
        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Users_Roles> User_Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("server=.;database=APICoreTesting1;trusted_connection=true");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users {UserId=1, UserName = "Admin", Password = "12345", Email = "Admin@Admin.com" });
            modelBuilder.Entity<Roles>().HasData(
                new Roles {RoleId=1, RoleName = "Admin" });
            modelBuilder.Entity<Users_Roles>().HasData(
                new Users_Roles {Id=1, UserId = 1, RoleId = 1 });
        }
    }
}
