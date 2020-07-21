using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ScratchToAdvanceAspcoreApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

/*
            app.Use
                (
                   async(context,next)=>
                   {
                       await context.Response.WriteAsync("Hellow Rabiul");
                       await next();

                       await context.Response.WriteAsync("Hellow Rabiul Response");
                   }
                );


            app.Use
               (
                  async (context, next) =>
                  {
                      await context.Response.WriteAsync("Hellow Rabiul Hasan");
                      await next();
                      await context.Response.WriteAsync("Hellow Rabiul Hasan Response");
                  }
               );

            app.Use
              (
                 async (context, next) =>
                 {
                     await context.Response.WriteAsync("Hellow Rabiul Hasan Bahar");
                     await next();
                     await context.Response.WriteAsync("Hellow Rabiul Hasan Response");
                 }
              );*/

            app.UseRouting();



           /* app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet
                ("/", async context=>
                {
                   await context.Response.WriteAsync("Hello Friends");
                }
                   
                );
            });*/

            app.UseEndpoints(endpoints =>
            {
                /*endpoints.MapGet
                ("/rabiul", async context =>
                {
                    await context.Response.WriteAsync("Hello Friends From Rabiul");
                }

                );*/

                endpoints.MapDefaultControllerRoute();


            });
        }


    }
}
