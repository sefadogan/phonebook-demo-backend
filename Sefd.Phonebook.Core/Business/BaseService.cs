using AutoMapper;
using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Core.Business
{
    public class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
          where TEntity : class, IEntity, new()
          where TDto : class, IDto, new()
    {
        public readonly IMapper _mapper;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
