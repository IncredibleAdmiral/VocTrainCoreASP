using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using VocTrainerCoreASP.Models;
using VocTrainerCoreASP.Interfaces;

namespace VocTrainerCoreASP
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddTransient<IGetTask, RandomExercise>();
            services.AddTransient<IChecksAnswer, Checks>();
          
            services.AddMvcCore().AddRazorViewEngine();
          

        }

     
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
