using AutoMapper;
using Scrumler.Bll;
using Scrumler.Bll.Abstract;
using Scrumler.Dal;
using Scrumler.Dal.Abstract;
using Scrumler.Dal.Abstract.Repository;
using Scrumler.Dal.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace Scrumler.WebApi
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
            #region JwtTokenSection

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            //services.AddAuthentication()
            //.AddJwtBearer(cfg =>
            //{
            //    cfg.RequireHttpsMetadata = false;
            //    cfg.SaveToken = true;

            //    cfg.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ClockSkew = TimeSpan.FromMinutes(5),
            //        RoleClaimType = "Roles",
            //        RequireSignedTokens = true,
            //        RequireExpirationTime = true,
            //        ValidateLifetime = true,
            //        ValidateAudience = true,
            //        ValidIssuer = Configuration["Tokens:Issuer"],
            //        ValidateIssuer = true,
            //        ValidAudience = Configuration["Tokens:Issuer"],
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))
            //    };
            //});

            #endregion JwtTokenSection

            #region ApplicationDbContextSection

            services.AddDbContext<ScrumlerContext>();
            services.AddScoped<DbContext, ScrumlerContext>();

            #endregion ApplicationDbContextSection

            #region InjectionSection

            services.AddScoped<IUnitofWork, UnitofWork>();

            #region BlSection

            services.AddScoped<IKullaniciBL, KullaniciBL>();
            services.AddScoped<IKullaniciYetkiBL, KullaniciYetkiBL>();
            services.AddScoped<IYetkiBL, YetkiBL>();

            #endregion BlSection

            #region RepositorySection

            services.AddScoped<IKullaniciRepository, KullaniciRepository>();
            services.AddScoped<IKullaniciYetkiRepository, KullaniciYetkiRepository>();
            services.AddScoped<IYetkiRepository, YetkiRepository>();

            #endregion RepositorySection

            #endregion InjectionSection

            #region SwaggerSection

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Scrumler WebApi"
                });

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            #endregion SwaggerSection

            #region CorsSection

            //Cors ayarlarý
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    //.WithOrigins("http://localhost:4200")
                    .AllowAnyOrigin()
                    //.WithMethods("GET", "POST")
                    .AllowAnyMethod()
                    //.WithHeaders("accept", "content-type", "origin", "No-Auth")
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            #endregion CorsSection

            services.AddAutoMapper();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Scrumler Web Api");
            });

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