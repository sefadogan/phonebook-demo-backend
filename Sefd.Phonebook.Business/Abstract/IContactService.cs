using Sefd.Phonebook.Core.Business;
using Sefd.Phonebook.Core.Utils.Results;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Business.Abstract
{
    public interface IContactService : IBaseService
    {
        Task<IDataResult<ICollection<IContactForViewDto>>> GetList();
        Task<IDataResult<IContactForViewDto>> GetById(int id);
        Task<ISuccessResult> AddAsync(IContactForCreateDto contactForCreateDto);
    }
}
