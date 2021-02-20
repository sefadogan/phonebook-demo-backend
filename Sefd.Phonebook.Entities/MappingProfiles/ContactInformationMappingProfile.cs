using AutoMapper;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;
using Sefd.Phonebook.Entities.Concretes.Dtos;
using Sefd.Phonebook.Entities.Concretes.Entities;
using Sefd.Phonebook.Entities.Concretes.ViewModels.ContactInformation;

namespace Sefd.Phonebook.Entities.MappingProfiles
{
    public class ContactInformationMappingProfile : Profile
    {
        public ContactInformationMappingProfile()
        {
            CreateMap<ContactInformation, ContactInformationDto>().ReverseMap();
            CreateMap<ContactInformationDto, ContactInformationForViewVM>().ReverseMap();
            CreateMap<IContactInformationDto, IContactInformationForViewVM>().ReverseMap();
            CreateMap<ContactInformationForCreateVM, IContactInformationDto>().ReverseMap();
            CreateMap<ContactInformation, IContactInformationDto>().ReverseMap();
        }
    }
}
