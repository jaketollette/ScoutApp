using AutoMapper;
using CoreApp.Core.Abstract;
using CoreApp.Core.Services;
using CoreApp.Infrastructure.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreApp.WebUI
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddAutoMapper();
      services.AddMvc();

      // Setup database in virtual method for test override.
      ConfigureDatabase(services);

      services.AddTransient<IScoutService, ScoutService>();
      services.AddTransient<IScoutRepository, ScoutRepository>();
    }

    public virtual void ConfigureDatabase(IServiceCollection services)
    {
      services.AddDbContext<ScoutContext>(opts =>
      {
        opts.UseSqlServer(Configuration.GetConnectionString("ScoutDatabase"))
              .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    // Marked virtual for test override.
    public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseBrowserLink();
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
      }

      app.UseSpa(spa =>
      {
        spa.Options.SourcePath = "src";
        if (env.IsDevelopment())
        {
          spa.UseAngularCliServer(npmScript: "start");
        }
      });

      app.UseStaticFiles();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");

        routes.MapSpaFallbackRoute(
            name: "spa-fallback",
            defaults: new { controller = "Home", action = "Index" });
      });
    }
  }
}
