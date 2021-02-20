using Sefd.Phonebook.Entities.Abstracts.Dtos;

namespace Sefd.Phonebook.Entities.Concretes.Dtos
{
    class ContactInformationDto : IContactInformationDto
    {
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public IContactDto Contact { get; set; }
    }
}
