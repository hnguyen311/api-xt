using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSU.TS.API.Data;
using HSU.TS.API.Data.Interfaces;
using HSU.TS.API.Data.Models;
using HSU.TS.API.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace HSU.TS.API
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
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
                });
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins(new string[] {"xt.api.hoasen.edu.vn","localhost", "https://www.hoasen.edu.vn" })
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials()
                .Build());
            });


            services.AddDbContext<XTDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultDatabase")));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            // services.Configure<SessionConfig>(Configuration.GetSection("SessionConfig"));

            //services.Configure<MvcOptions>(options =>
            //{
            //    options.Filters.Add(new RequireHttpsAttribute());
            //});

            services.AddMvc();
            services.AddScoped<ValidateModelAttribute>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseCors("CorsPolicy");
            //app.UseMvc();
            // app.UseMvcWithDefaultRoute();

           // var options = new RewriteOptions().AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 44344);
           // app.UseRewriter(options);
            app.UseMvc(routes =>
            {
                routes.MapRoute("APIDefault", "api/{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
