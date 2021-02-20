using AutoMapper;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;
using Sefd.Phonebook.Entities.Concretes.Dtos.Contact;
using Sefd.Phonebook.Entities.Concretes.Entities;
using Sefd.Phonebook.Entities.Concretes.ViewModels.Contact;

namespace Sefd.Phonebook.Entities.MappingProfiles
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<Contact, ContactForViewDto>().ReverseMap();
            CreateMap<ContactForViewDto, ContactForViewVM>().ReverseMap();
            CreateMap<IContactForViewDto, IContactForViewVM>().ReverseMap();
            CreateMap<ContactForCreateVM, IContactForCreateDto>().ReverseMap();
            CreateMap<Contact, IContactForViewDto>().ReverseMap();
            CreateMap<Contact, IContactForCreateDto>().ReverseMap();
        }
    }
}
