using Sefd.Phonebook.Core.Business;
using Sefd.Phonebook.Core.Utils.Results;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Concretes.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Business.Abstract
{
    public interface IContactService : IBaseService
    {
        Task<IDataResult<ICollection<IContactForViewDto>>> GetListAsync(Expression<Func<Contact, bool>> where = null,
            params Expression<Func<Contact, object>>[] includes);
        Task<IDataResult<IContactForViewDto>> GetByIdAsync(int id);
        Task<ISuccessResult> AddAsync(IContactForCreateDto contactForCreateDto);
        Task<ISuccessResult> SoftDeleteAsync(int id);
        Task<ISuccessResult> UpdatePartialAsync(int id, IContactForUpdateDto contactForUpdateDto);
    }
}
