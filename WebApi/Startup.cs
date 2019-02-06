using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace WebApi
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
            //CORS
            var corsSettings = Configuration.GetSection("CORS");
            var allowOrigins = Array.ConvertAll(corsSettings["AllowOrigin"].Split(','), p => p.Trim());
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", 
                    b => b.WithOrigins(allowOrigins)
                        .SetPreflightMaxAge(TimeSpan.FromMinutes(15)) //Cache CORS preflight OPTIONS
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                );
            });

            services.AddAuthentication(IISDefaults.AuthenticationScheme); //Windows authentication with AD

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options =>
                {
                    var settings = options.SerializerSettings;
                    //Use CamelCasePropertyNamesContractResolver for the camelCase json serialization,so Id => id, Name => name
                    //The DefaultContractResolver keeps the C# model json serialization casing, whatever it is, usualy PascalCase.
                    settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    settings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    settings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
                    settings.Formatting = Newtonsoft.Json.Formatting.Indented;
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowSpecificOrigin"); //Enable CORS!!!
            //app.UseCors(options =>
            //    options
            //    .AllowAnyOrigin()
            //    .AllowAnyMethod()
            //    .AllowAnyHeader()
            //    .AllowCredentials() //Unable to use this with AllowAnyOrigin() https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2
            //    );
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles(); // Enables default file mapping on the /wwwroot.
            app.UseStaticFiles();
            app.UseStatusCodePages(); // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-2.1

            app.UseMvc();
        }
    }
}
