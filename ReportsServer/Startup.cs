using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ReportsServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<IISOptions>(options => options.ForwardClientCertificate = 
                                                      options.AutomaticAuthentication=false);
            services.AddMvc();
            //services.AddDbContext<ConfsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AlphaConfigConnection")));
            services.AddScoped<IAeEventRepository>(provider => new AeEventRepository(Configuration.GetConnectionString("AlphaServerConnection"), Configuration.GetConnectionString("AlphaConfigConnection")));
            //DbContext reportsConfig= new ContextFactory(Configuration.GetConnectionString("AlphaConfigConnection")).CreateContext();
            //services.AddDbContext<AeEventContext>();
            //services.AddScoped<IContextFactory>(provider => new ContextFactory(Configuration.GetConnectionString("AlphaConfigConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "DefaultApi",
                    template: "api/{controller}/{action}");
            });

        }
    }
}
