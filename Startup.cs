using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using OpticEngine.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpticEngine.Services;
using OpticEngine.Repositories;
using AutoMapper;
using OpticEngine.Services.BankInfo;
using OpticEngine.Repositories.Bank;

namespace OpticEngine
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => {
            options.SignIn.RequireConfirmedAccount = false;
            options.Lockout.AllowedForNewUsers = true;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
            options.Lockout.MaxFailedAccessAttempts = 10;
           })

                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireSuperUserRole",
                 policy=>policy.RequireRole("Admin", "PowerUser", "BackupAdministrator","CTO"));
               
            });

            services.AddControllersWithViews();


           services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest)
          .AddRazorPagesOptions(options =>
          {
                options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
          });

            services.AddRazorPages();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IHolidaysRepository, HolidaysRepository>();
            services.AddScoped<IHolidaysService, HolidaysService>();
            services.AddScoped<IBankInfoService, BankInfoService>();
            services.AddScoped<IBankInfoRepository, BankInfoRepository>();


            services.AddScoped<IEmergencyContactRepository, EmergencyContactRepostiory>();
            services.AddScoped<IEmergencyContactService, EmergencyContactService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
          

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Dashboard}/{action=EmployeeIndex}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
