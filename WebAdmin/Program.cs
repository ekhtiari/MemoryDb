using Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdmin
{
    public class Program
    {
         public static void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;
            //var context = services.GetRequiredService<ApplicationDbcontextInMemory>();

            DataGenerator.InitData(services);

            host.Run();

            //CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            //Host.CreateDefaultBuilder(args)
            //    .ConfigureWebHostDefaults(webBuilder =>
            //    {
            //        webBuilder.UseStartup<Startup>();
            //    });

            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(o => o.ClearProviders()).UseStartup<Startup>();
    }
}
