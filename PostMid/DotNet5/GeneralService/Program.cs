using GeneralService.Infrastructures;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneralService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();
                    var configuration = new ConfigurationBuilder().AddConfiguration(configurationRoot).Build();

                    webBuilder.ConfigureAppConfiguration(x => x.AddConfiguration(configuration)).UseStartup<Startup>();

                    var serviceConfig = new ServiceConfiguration();
                    configuration.GetSection("ServiceConfiguration").Bind(serviceConfig);
                    webBuilder.UseUrls(serviceConfig.Url);
                });
    }
}
