using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.Dtos.Contact
{
    public class ContactForViewDto : IContactForViewDto
    {
        public int ContactInformationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public ICollection<IContactInformationForViewDto> ContactInformations { get; set; }
    }
}
