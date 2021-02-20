using AutoMapper;

namespace Sefd.Phonebook.Core.Business
{
    public class BaseService : IBaseService
    {
        public readonly IMapper _mapper;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
