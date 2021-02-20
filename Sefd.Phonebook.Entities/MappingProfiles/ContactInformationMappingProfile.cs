using AutoMapper;
using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;
using Sefd.Phonebook.Entities.Concretes.Dtos.ContactInformation;
using Sefd.Phonebook.Entities.Concretes.Entities;
using Sefd.Phonebook.Entities.Concretes.ViewModels.ContactInformation;

namespace Sefd.Phonebook.Entities.MappingProfiles
{
    public class ContactInformationMappingProfile : Profile
    {
        public ContactInformationMappingProfile()
        {
            CreateMap<ContactInformation, ContactInformationForViewDto>().ReverseMap();
            CreateMap<ContactInformationForViewDto, ContactInformationForViewVM>().ReverseMap();
            CreateMap<IContactInformationForViewDto, IContactInformationForViewVM>().ReverseMap();
            CreateMap<ContactInformationForCreateVM, IContactInformationForViewDto>().ReverseMap();
            CreateMap<ContactInformation, IContactInformationForViewDto>().ReverseMap();
        }
    }
}
