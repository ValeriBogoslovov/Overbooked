﻿using System;
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
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<OverbookedDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OverbookedContextConnection")));

                services.AddIdentity<User, IdentityRole>(options => {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<OverbookedDbContext>()
                .AddDefaultTokenProviders();
            });
        }
    }
}