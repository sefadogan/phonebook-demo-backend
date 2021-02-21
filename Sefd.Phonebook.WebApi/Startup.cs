using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Business.Concrete;
using Sefd.Phonebook.Business.DependencyResolvers.DotNetCore;
using Sefd.Phonebook.DataAccess.Abstract;
using Sefd.Phonebook.DataAccess.Concrete.EntityFramework;
using Sefd.Phonebook.Entities.MappingProfiles;

namespace Sefd.Phonebook.WebApi
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
            // Inject AutoMapper
            services.AddAutoMapper(typeof(Startup));
            EntityMappingProfilesManager.AddProfiles(services);

            services.AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", builder =>
                {
                    builder.WithOrigins("http://localhost:3000");
                });
                options.AddPolicy("Methods", builder =>
                {
                    builder.WithOrigins("http://localhost:3000");
                });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sefd.Phonebook.WebApi", Version = "v1" });
            });

            DotNetCoreBusinessModule.Load(services);

            // Formating urls to lowercase
            services.AddRouting(options => options.LowercaseUrls = true);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sefd.Phonebook.WebApi v1"));
            }

             app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:3000").AllowAnyHeader();
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
