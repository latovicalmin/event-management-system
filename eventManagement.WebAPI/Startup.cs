using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using eventManagement.WebAPI.Filters;
using eventManagement.WebAPI.Security;
using eventManagement.WebAPI.Services;
using eventManagement.WebAPI.Services.CategoryServices;
using eventManagement.WebAPI.Services.CityServices;
using eventManagement.WebAPI.Services.EventServices;
using eventManagement.WebAPI.Services.OrganizationServices;
using eventManagement.WebAPI.Services.UserServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace eventManagement.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }

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

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<ICRUDService<Event, EventSearchRequest, EventUpsertRequest, EventUpsertRequest>, EventsService>();
            services.AddScoped<ICRUDService<Rating, RatingSearchRequest, RatingUpsertRequest, RatingUpsertRequest>, RatingServices>();
            services.AddScoped<ICRUDService<Model.Participants, ParticipantSearchRequest, ParticipantUpsertRequest, ParticipantUpsertRequest>, ParticipantsService>();
            services.AddScoped<IUsersService, UsersServices>();
            services.AddScoped<IEventsService, EventsService>();
            services.AddScoped<IService<City, CitySearchRequest>, CitiesService>();
            services.AddScoped<IService<Country, object>, BaseService<Country, object, Countries>>();
            services.AddScoped<IService<Model.EventCategories, object>, BaseService<Model.EventCategories, object, Database.EventCategories>>();
            services.AddScoped<ICRUDService<Organization, OrganizationsSearchRequest, OrganizationUpsertRequest, OrganizationUpsertRequest>, OrganizationsService>();
            services.AddScoped<ICRUDService<Category, CategorySearchRequest, CategoryUpsertRequest, CategoryUpsertRequest>, CategoriesService>();
            services.AddScoped<IService<Model.Speakers, object>, BaseService<Model.Speakers, object, Database.Speakers>>();
            services.AddScoped<IService<Model.UserOrganizations, object>, BaseService<Model.UserOrganizations, object, Database.UserOrganizations>>();
            services.AddScoped<IService<Role, object>, BaseService<Role, object, Roles>>();
            services.AddScoped<IService<Model.UserRoles, object>, BaseService<Model.UserRoles, object, Database.UserRoles>>();

            var connection = @"Server=.;Database=130074;Trusted_Connection=True;";
            services.AddDbContext<eventsContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();
            // app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
