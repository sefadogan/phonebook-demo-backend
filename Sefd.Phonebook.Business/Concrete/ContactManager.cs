using AutoMapper;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Core.Business;
using Sefd.Phonebook.Core.Utils.Results;
using Sefd.Phonebook.DataAccess.Abstract;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Concretes.Dtos;
using Sefd.Phonebook.Entities.Concretes.Dtos.Contact;
using Sefd.Phonebook.Entities.Concretes.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Business.Concrete
{
    public class ContactManager : BaseService, IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal, IMapper mapper) : base(mapper)
        {
            _contactDal = contactDal;
        }

        public async Task<IDataResult<ICollection<IContactForViewDto>>> GetListAsync()
        {
            ICollection<IContactForViewDto> contactDtos = new List<IContactForViewDto>();

            var contacts = await _contactDal.ListAsync();
            foreach (var contact in contacts)
            {
                var mappedContact = _mapper.Map<ContactForViewDto>(contact);
                contactDtos.Add(mappedContact);
            }

            return new DataResult<ICollection<IContactForViewDto>>(contactDtos, true);
        }

        public async Task<IDataResult<IContactForViewDto>> GetByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id cannot be zero or less!");

            var contact = await _contactDal.GetByIdAsync(id);
            var mappedContact = _mapper.Map<ContactForViewDto>(contact);

            return new DataResult<IContactForViewDto>(mappedContact, true);
        }

        public async Task<ISuccessResult> AddAsync(IContactForCreateDto contactForCreateDto)
        {
            var mappedContact = _mapper.Map<Contact>(contactForCreateDto);
            await _contactDal.AddAsync(mappedContact);

            return new SuccessResult();
        }

        public async Task<ISuccessResult> SoftDeleteAsync(int id)
        {
            var contact = await _contactDal.GetByIdAsync(1);
            contact.IsDeleted = true;

            await _contactDal.UpdateAsync(contact);

            return new SuccessResult();
        }
    }
}
