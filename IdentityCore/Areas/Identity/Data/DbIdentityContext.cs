using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityCore.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCore.Data
{
    public class DbIdentityContext : IdentityDbContext<AppUsers>
    {
        public DbIdentityContext(DbContextOptions<DbIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            var roleId = new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210");
            var adminId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9");
            var pHash = new PasswordHasher<AppUsers>();
            builder.Entity<AppUsers>().HasData(new AppUsers
            {
                Id = adminId.ToString(),
                Firstname = "Henry",
                lastname = "de Aaron",
                UserName = "huvny@gmail.com",
                NormalizedUserName = "huvny@gmail.com",
                Email = "huvny@gmail.com",
                NormalizedEmail = "huvny@gmail.com",
                PhoneNumber = "0954683265",
                EmailConfirmed = true,
                PasswordHash = pHash.HashPassword(null, "Abc123!@#"),
                SecurityStamp = Guid.NewGuid().ToString(),

            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId.ToString(),
                Name = "admin",
                NormalizedName = "admin",
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId.ToString(),
                UserId = adminId.ToString()
            });
        }
    }
}
