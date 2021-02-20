using Sefd.Phonebook.Entities.Abstracts.Dtos;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.Dtos
{
    public class ContactDto : IContactDto
    {
        public int ContactInformationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public ICollection<IContactInformationDto> ContactInformations { get; set; }
    }
}
