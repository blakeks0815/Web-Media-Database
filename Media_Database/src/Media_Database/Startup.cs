using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Media_Database.Functions;
using Media_Database.Models;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Data.Entity;

namespace Media_Database
{
    public class Startup
    {

        public IConfigurationRoot Configuration { get; set; }
        private MediaObjectsContext context;

        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv) {
            var builder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("settings.json");
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connection = Configuration["Production:SqliteConnectionString"];

            services.AddEntityFramework()
                .AddSqlite()
                .AddDbContext<MediaObjectsContext>(options => options.UseSqlite(connection));

            //services.AddScoped<MediaObjectsContext>();

            //create dbContext without dependency injection;
            //context = new MediaObjectsContext();
            //context.Database.EnsureCreated();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" }
                    );
            });

            //important to use local files (like css, js ...)
            app.UseStaticFiles();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
