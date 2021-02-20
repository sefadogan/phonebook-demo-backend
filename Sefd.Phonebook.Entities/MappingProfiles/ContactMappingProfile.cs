using AutoMapper;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;
using Sefd.Phonebook.Entities.Concretes.Dtos;
using Sefd.Phonebook.Entities.Concretes.Entities;
using Sefd.Phonebook.Entities.Concretes.ViewModels.Contact;

namespace Sefd.Phonebook.Entities.MappingProfiles
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<ContactDto, ContactForViewVM>().ReverseMap();
            CreateMap<IContactDto, IContactForViewVM>().ReverseMap();
            CreateMap<ContactForCreateVM, IContactDto>().ReverseMap();
            CreateMap<Contact, IContactDto>().ReverseMap();
        }
    }
}
