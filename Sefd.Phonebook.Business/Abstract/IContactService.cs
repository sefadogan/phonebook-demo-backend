using Sefd.Phonebook.Core.Business;
using Sefd.Phonebook.Core.Utils.Results;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Business.Abstract
{
    public interface IContactService : IBaseService
    {
        Task<IDataResult<ICollection<IContactForViewDto>>> GetListAsync();
        Task<IDataResult<IContactForViewDto>> GetByIdAsync(int id);
        Task<ISuccessResult> AddAsync(IContactForCreateDto contactForCreateDto);
        Task<ISuccessResult> SoftDeleteAsync(int id);
    }
}
