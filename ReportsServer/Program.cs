using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ReportsServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json"); //1
            var config = builder.Build(); // 1

            using (var scope = host.Services.CreateScope()) //2
            {
                var services = scope.ServiceProvider;
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
    }
}