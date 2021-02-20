using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Core.Business
{
    public interface IBaseService<TEntity, TDto>
        where TEntity : class, IEntity, new()
        where TDto : class, IDto, new()
    {
    }
}
