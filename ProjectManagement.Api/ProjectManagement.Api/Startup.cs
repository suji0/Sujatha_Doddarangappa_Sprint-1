using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProjectManagement.Data.Interfaces;
using ProjectManagement.Data.Implementation;
using ProjectManagement.Entities;
using ProjectManagement.Api.Controllers;

namespace ProjectManagement.Api
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
          /*  services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project Management API", Version = "v1" });
            }); */

            services.AddControllers();

            services.AddTransient<IBaseRepository<User>, BaseRepository<User>>();

            services.AddTransient<IBaseRepository<Task>, BaseRepository<Task>>();

            services.AddTransient<IBaseRepository<Project>, BaseRepository<Project>>();

            services.AddTransient<BaseController<Project>, ProjectController>();

            services.AddTransient<BaseController<Task>, TaskController>();

            services.AddTransient<BaseController<User>, UserController>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /*app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project API V1");
            });
            */
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
