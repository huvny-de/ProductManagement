using System;
using IdentityCore.Areas.Identity.Data;
using IdentityCore.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityCore.Areas.Identity.IdentityHostingStartup))]
namespace IdentityCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<DbIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ConnectionString")));

                services.AddDefaultIdentity<AppUsers>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<DbIdentityContext>();
            });
        }
    }
}