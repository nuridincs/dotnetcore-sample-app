using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Myapp.Web.Data;
using Myapp.Web.Models;

namespace Myapp.Web
{
    public class Startup
    {
        // public Startup(IConfiguration configuration)
        // {
        //     Configuration = configuration;
        // }

         public IConfiguration Configuration { get; }

        //private IConfiguration _config;
        public Startup(IConfiguration configuration)
        {
            //_config = config;
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IStudent, StudentRepository>();
            services.AddControllersWithViews();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // DefaultFilesOptions fileDefaultOption = new DefaultFilesOptions();
            // fileDefaultOption.DefaultFileNames.Clear();
            // fileDefaultOption.DefaultFileNames.Add("hello.html");
            // app.UseDefaultFiles(fileDefaultOption);
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                // endpoints.MapGet("/", async context => {
                //     // throw new Exception("Pesan Error");
                //     await context.Response.WriteAsync("Hello ASP Core \n");
                // });
            });
        }
    }
}
