using CalendarE2.Data;
using CalendarE2.Data.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace CalendarE2.WebApp
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
            var tenantId = $"{Configuration["AzureAD:TenantId"]}";
            var authority = $"{Configuration["AzureAD:Instance"]}/{tenantId}";
            var audience = new List<string>
            {
                $"{Configuration["AzureAD:ClientId"]}",
                $"{Configuration["AzureAD:Scope"]}"
        };
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = authority;
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidAudiences = audience,
                        ValidIssuers = new List<string>
                        {
                            $"https://sts.windows.net/{tenantId}",
                            $"https://sts.windows.net/{tenantId}/v2.0"
                        }
                    };
                });
            services.AddControllersWithViews();
            // Context Gets Connection String from appsettings.Development.json file
            // dev environment specified in Properties in launchSettings.json
            services.AddDbContext<CalendarContext>(options =>
                    //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                    options.UseSqlServer(Configuration.GetConnectionString("AzureConnStr")));
            services.AddScoped<EventService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
