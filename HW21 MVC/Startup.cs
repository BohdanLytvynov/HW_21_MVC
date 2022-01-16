using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ORM;
using Microsoft.Extensions.Configuration;
using HW21_MVC.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HW21_MVC
{
    public class Startup
    {
        public IConfiguration Config { get;}//Config file(stores connection string)

        //ctor initializes Configuration file // DI
        public Startup(IConfiguration config)
        {
            Config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Add MVC functions
            services.AddControllersWithViews();

            //Binding Configuration with appsettings.json
            Config.Bind("Project", new Config());

            //Adding DB Context to create ORM System for managing data base
            services.AddDbContext<DataContext>(x => x.UseSqlServer(
                Configuration.Config.ConnectionString                
                )) ;

            //Add Repository that will store dbSets form data base tables using DI
            services.AddScoped<IRepository, EFRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//Using Static files (wwwroot)

            app.UseRouting();//Use routing system

            //Endpoint System to enable start up page
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "home", "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
