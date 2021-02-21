using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;

namespace Sefd.Phonebook.Entities.Concretes.Dtos.ContactInformation
{
    class ContactInformationForViewDto : IContactInformationForViewDto
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public IContactForViewDto Contact { get; set; }
    }
}
