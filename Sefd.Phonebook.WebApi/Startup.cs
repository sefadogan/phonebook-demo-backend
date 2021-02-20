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
            //inject automapper
            services.AddAutoMapper(typeof(Startup));
            EntityMappingProfilesManager.AddProfiles(services);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sefd.Phonebook.WebApi", Version = "v1" });
            });

            DotNetCoreBusinessModule.Load(services);
            //services.AddSingleton<IContactDal, EfContactDal>();
            //services.AddSingleton<IContactService, ContactManager>();
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
