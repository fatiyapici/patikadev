using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MiddlewarePractices.Middlewares;

namespace MiddlewarePractices
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MiddlewarePractices", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiddlewarePractices v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.Run();
            // app.Run(async context => System.Console.WriteLine("Middleware 1 basladi."));
            // app.Run(async context => System.Console.WriteLine("Middleware 2 basladi."));

            //app.Use();
            // app.Use(async (context, next) =>
            // {
            //     Console.WriteLine("Middleware 1 basladi.");
            //     await next.Invoke();
            //     Console.WriteLine("Middleware 1 sonlandiriliyor.");
            // });

            // app.Use(async (context, next) =>
            // {
            //     Console.WriteLine("Middleware 2 basladi.");
            //     await next.Invoke();
            //     Console.WriteLine("Middleware 2 sonlandiriliyor.");
            // });

            // app.Use(async (context, next) =>
            // {
            //     Console.WriteLine("Middleware 3 basladi.");
            //     await next.Invoke();
            //     Console.WriteLine("Middleware 3 sonlandiriliyor.");
            // });

            //Custom Middleware
            app.UseHello();

            app.Use(async (context, next) =>
            {
                Console.WriteLine("Use mıddleware tetiklendi.");
                await next.Invoke();
            });

            app.Map("/example", internalApp => internalApp.Run(async context =>
            {
                System.Console.WriteLine("/example middleware tetiklendi");
                await context.Response.WriteAsync("/example middleware tetiklendi");
            }));

            app.MapWhen(x => x.Request.Method == "GET", internalApp =>
            {
                internalApp.Run(async context =>
                {
                    System.Console.WriteLine("Middleware tetiklendi");
                    await context.Response.WriteAsync("MapWhen Middleware tetiklendi");
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
