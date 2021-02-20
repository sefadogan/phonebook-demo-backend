using Sefd.Phonebook.Core.DataAccess;
using Sefd.Phonebook.Entities.Concretes.Entities;

namespace Sefd.Phonebook.DataAccess.Abstract
{
    public interface IContactDal : IEntityRepository<Contact>
    {
    }
}
