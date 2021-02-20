using AutoMapper;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Core.Business;
using Sefd.Phonebook.Core.Utils.Results;
using Sefd.Phonebook.DataAccess.Abstract;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Concretes.Dtos;
using Sefd.Phonebook.Entities.Concretes.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Business.Concrete
{
    public class ContactManager : BaseService<Contact, ContactDto>, IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal, IMapper mapper) : base(mapper)
        {
            _contactDal = contactDal;
        }

        public async Task<IDataResult<ICollection<IContactDto>>> GetList()
        {
            ICollection<IContactDto> contactDtos = new List<IContactDto>();

            var contacts = await _contactDal.ListAsync();
            foreach (var contact in contacts)
            {
                var convertedContacts = _mapper.Map<Contact, ContactDto>(contact);
                contactDtos.Add(convertedContacts);
            }

            return new DataResult<ICollection<IContactDto>>(contactDtos, true);
        }
    }
}
