using Commons;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeneralService
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GeneralService", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowAllOrigins", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.AddControllers(x => x.AllowEmptyInputInBodyModelBinding = true).AddJsonOptions(option =>
            {
                option.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GeneralService v1"));
            }

            app.UseRouting();

            app.UseCors("AllowAllOrigins");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            RegistryServiceConfiguration registryConfig = new RegistryServiceConfiguration();
            Configuration.GetSection(RegistryServiceConfiguration.ConfigSection).Bind(registryConfig);

            ServiceConfiguration serviceConfig = new ServiceConfiguration();
            Configuration.GetSection(ServiceConfiguration.ConfigSection).Bind(serviceConfig);

            using(var httpClient = new HttpClient())
            {
                var cityController = new
                {
                    ServiceName = "GeneralService",
                    Url = serviceConfig.Url + "/api/City",
                    ControllerName = "CityController"
                };

                var result = httpClient.PostAsJsonAsync(registryConfig.Url + "/api/Registry/Register", cityController).Result;

                try
                {
                    result.EnsureSuccessStatusCode();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
