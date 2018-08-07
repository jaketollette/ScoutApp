using CoreApp.Infrastructure.Concrete;
using CoreApp.Tests.Common.Data;
using CoreApp.WebUI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoreApp.Tests.Integration.Fixtures
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration)
        { }

        public override void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<ScoutContext>(opts =>
            {
                opts.UseInMemoryDatabase("test_db")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            services.AddTransient<DatabaseSeeder>();
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            base.Configure(app, env);

            // Seed DB
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var seeder = serviceScope.ServiceProvider.GetService<DatabaseSeeder>();
                seeder.Seed();
            }
        }
    }
}

