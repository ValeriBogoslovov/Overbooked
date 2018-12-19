using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Overbooked.Web.Models;
using Overbooked.Data;
using Overbooked.Data.Models;

[assembly: HostingStartup(typeof(Overbooked.Web.Areas.Identity.IdentityHostingStartup))]
namespace Overbooked.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OverbookedContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OverbookedContextConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<OverbookedContext>();
            });
        }
    }
}