using Microsoft.Extensions.DependencyInjection;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Business.Concrete;
using Sefd.Phonebook.DataAccess.Abstract;
using Sefd.Phonebook.DataAccess.Concrete.EntityFramework;

namespace Sefd.Phonebook.Business.DependencyResolvers.DotNetCore
{
    public class DotNetCoreBusinessModule
    {
        public static void Load(IServiceCollection services)
        {
            services.AddSingleton<IContactDal, EfContactDal>();
            services.AddSingleton<IContactService, ContactManager>();
        }
    }
}
