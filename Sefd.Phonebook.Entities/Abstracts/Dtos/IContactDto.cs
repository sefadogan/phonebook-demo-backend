using Sefd.Phonebook.Core.Entities;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos
{
    public interface IContactDto : IDto
    {
        int ContactInformationId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string CompanyName { get; set; }

        ICollection<IContactInformationDto> ContactInformations { get; set; }
    }
}
