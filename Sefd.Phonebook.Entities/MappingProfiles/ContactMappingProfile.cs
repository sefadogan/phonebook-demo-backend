using AutoMapper;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Abstracts.ViewModels;
using Sefd.Phonebook.Entities.Concretes.Dtos;
using Sefd.Phonebook.Entities.Concretes.Entities;
using Sefd.Phonebook.Entities.Concretes.ViewModels;

namespace Sefd.Phonebook.Entities.MappingProfiles
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<ContactDto, ContactVM>().ReverseMap();
            CreateMap<IContactDto, IContactVM>().ReverseMap();
        }
    }
}
