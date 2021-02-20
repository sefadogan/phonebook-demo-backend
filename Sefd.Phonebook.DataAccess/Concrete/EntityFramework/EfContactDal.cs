using Sefd.Phonebook.Core.DataAccess.EntityFramework;
using Sefd.Phonebook.DataAccess.Abstract;
using Sefd.Phonebook.DataAccess.Concrete.EntityFramework.Context;
using Sefd.Phonebook.Entities.Concretes.Entities;

namespace Sefd.Phonebook.DataAccess.Concrete.EntityFramework
{
    public class EfContactDal : EfEntityRepositoryBase<Contact, PhonebookDbContext>, IContactDal
    {
    }
}
