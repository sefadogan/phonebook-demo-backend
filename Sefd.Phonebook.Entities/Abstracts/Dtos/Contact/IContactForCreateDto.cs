using Sefd.Phonebook.Core.Entities;
using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos.Contact
{
    public interface IContactForCreateDto : IDto
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string CompanyName { get; set; }

        ICollection<IContactInformationForCreateDto> ContactInformations { get; set; }
    }
}
