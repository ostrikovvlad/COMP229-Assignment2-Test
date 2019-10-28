﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration conf) => Configuration = conf;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:TastyRecipes:ConnectionString"]));

            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "pagination",
                    template: "Recipe/Page{productPage}",
                    defaults: new { Controller = "Recipe", action = "List" }
                    );
                routes.MapRoute(
                    name: "details",
                    template: "Recipe/Details/{recipeId}",
                    defaults: new { Controller = "Recipe", action = "ViewRecipe" });
                routes.MapRoute(name: "default",
                    template: "{controller=Recipe}/{action=Index}");

            }
            );
            SeedData.EnsurePopulated(app);
        }
    }
}
