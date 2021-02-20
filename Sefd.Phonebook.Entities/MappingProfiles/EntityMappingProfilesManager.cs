using Microsoft.Extensions.DependencyInjection;

namespace Sefd.Phonebook.Entities.MappingProfiles
{
    public class EntityMappingProfilesManager
    {
        public static void AddProfiles(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EntityMappingProfilesManager));
        }
    }
}
