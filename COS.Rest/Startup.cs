using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using COS.Data.Services;
using COS.Rest.Helpers;
using COS.Rest.Filters;
using FluentValidation.AspNetCore;


namespace COS.Rest
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

            //configure jwt authentication using extension method
            services.AddJwtSimple(Configuration);
            
            //enable cors processing
            services.AddCors();

            // turn off standard api validation filter to use our own
            // ValidationFilter to customise response
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            // configure controller, adding custom validation filter and fluent validation
            services.AddControllers(
                opts => opts.Filters.Add(new ValidationFilter())
            ).AddFluentValidation(
                fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>()
            );

            //CafeService configured Dependency Injection
            services.AddSingleton<ICafeService,CafeService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging(); //blazor

                CafeServiceSeeder.Seed(new CafeService());
            }

            //app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles(); //blazor
            app.UseStaticFiles(); //blazor

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html"); //blazor
            });
        }
    }
}
